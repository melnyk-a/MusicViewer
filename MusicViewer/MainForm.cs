using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MusicViewer
{
    delegate bool Comparer(DateTime first, DateTime second);

    public partial class MainForm : Form
    {
        private readonly XMLLoader loader = new XMLLoader();
        private IEnumerable<Track> tracks;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ArtistComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackListBox.Items.Clear();
            SetUpTimePicker();
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            albumTextBox.Text = null;
            releasedTextBox.Text = null;
            lengtTextBox.Text = null;
            genresTextBox.Text = null;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            trackListBox.Items.Clear();
            foreach (Track track in tracks)
            {
                DateTime.TryParse(track.Released, out DateTime result);

                if (track.Artist == artistComboBox.SelectedItem.ToString() &&
                    (result >= fromDateTimePicker.Value && 
                    result <= toDateTimePicker.Value))
                {
                    trackListBox.Items.Add(new TrackWrapper(track));
                }
            }
        }

        private Track FindFirst(string artist)
        {
            Track first = null;
            foreach (Track track in tracks)
            {
                if (track.Artist == artist)
                {
                    first = track;
                    break;
                }
            }
            return first;
        }

        private DateTime FindReleased(string artist, Comparer comparer)
        {
            DateTime.TryParse(FindFirst(artist).Released, out DateTime start);
            foreach (Track track in tracks)
            {
                if (track.Artist == artist)
                {
                    DateTime.TryParse(track.Released, out DateTime result);
                    if (comparer(start, result))
                    {
                        start = result;
                    }
                }
            }
            return start;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            string currentPath = Directory.GetCurrentDirectory();
            var info = new DirectoryInfo(currentPath);
            currentPath = info.Parent.Parent.FullName;
            openFileDialog.InitialDirectory = currentPath;
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            tracks = loader.Load(openFileDialog.FileName);
            artistComboBox.Items.Clear();
            foreach (Track track in tracks)
            {
                if (!artistComboBox.Items.Contains(track.Artist))
                {
                    artistComboBox.Items.Add(track.Artist);
                }
            }
            artistComboBox.Text = null;
            trackListBox.Items.Clear();
            ClearTextBoxes();
        }

        private void SetUpTimePicker()
        {
            fromDateTimePicker.Enabled = toDateTimePicker.Enabled = artistComboBox.SelectedIndex > -1;

            DateTime min = FindReleased(
                artistComboBox.SelectedItem.ToString(), 
                (DateTime first, DateTime second) => first > second
                );
            DateTime max = FindReleased(
                artistComboBox.SelectedItem.ToString(), 
                (DateTime first, DateTime second) => first < second
                );

            fromDateTimePicker.MinDate = toDateTimePicker.MinDate = DateTimePicker.MinimumDateTime;
            fromDateTimePicker.MaxDate = toDateTimePicker.MaxDate = DateTimePicker.MaximumDateTime;

            fromDateTimePicker.MinDate = toDateTimePicker.MinDate = min;
            fromDateTimePicker.MaxDate = toDateTimePicker.MaxDate = max;

            toDateTimePicker.Value = max;
        }

        private void TrackListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Track track = ((TrackWrapper)trackListBox.SelectedItem).Track;
            albumTextBox.Text = track.Album;
            DateTime.TryParse(track.Released, out DateTime result);
            releasedTextBox.Text = result.ToString("MMMM dd, yyyy");
            lengtTextBox.Text = track.Length;
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var genre in track.Genres)
            {
                stringBuilder.Append(genre.Name);
                stringBuilder.Append(Environment.NewLine);
            }
            genresTextBox.Text = stringBuilder.ToString();
        } 
    }
}