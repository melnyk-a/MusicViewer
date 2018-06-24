namespace MusicViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loadButton = new System.Windows.Forms.Button();
            this.artistComboBox = new System.Windows.Forms.ComboBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.trackListBox = new System.Windows.Forms.ListBox();
            this.albumLabel = new System.Windows.Forms.Label();
            this.releasedLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.genresLabel = new System.Windows.Forms.Label();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.releasedTextBox = new System.Windows.Forms.TextBox();
            this.lengtTextBox = new System.Windows.Forms.TextBox();
            this.genresTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(14, 10);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(102, 31);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // artistComboBox
            // 
            this.artistComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistComboBox.FormattingEnabled = true;
            this.artistComboBox.Location = new System.Drawing.Point(121, 12);
            this.artistComboBox.Name = "artistComboBox";
            this.artistComboBox.Size = new System.Drawing.Size(453, 28);
            this.artistComboBox.Sorted = true;
            this.artistComboBox.TabIndex = 1;
            this.artistComboBox.SelectedIndexChanged += new System.EventHandler(this.ArtistComboBox_SelectedIndexChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.Location = new System.Drawing.Point(12, 58);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(53, 20);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From:";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.fromDateTimePicker.Enabled = false;
            this.fromDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromDateTimePicker.Location = new System.Drawing.Point(71, 53);
            this.fromDateTimePicker.MaxDate = new System.DateTime(9970, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(229, 26);
            this.fromDateTimePicker.TabIndex = 3;
            this.fromDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLabel.Location = new System.Drawing.Point(306, 57);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(33, 20);
            this.toLabel.TabIndex = 4;
            this.toLabel.Text = "To:";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CustomFormat = "dd MMMM yyyy";
            this.toDateTimePicker.Enabled = false;
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toDateTimePicker.Location = new System.Drawing.Point(345, 53);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(229, 26);
            this.toDateTimePicker.TabIndex = 5;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // trackListBox
            // 
            this.trackListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trackListBox.FormattingEnabled = true;
            this.trackListBox.ItemHeight = 20;
            this.trackListBox.Location = new System.Drawing.Point(13, 94);
            this.trackListBox.Name = "trackListBox";
            this.trackListBox.Size = new System.Drawing.Size(287, 344);
            this.trackListBox.Sorted = true;
            this.trackListBox.TabIndex = 6;
            this.trackListBox.SelectedIndexChanged += new System.EventHandler(this.TrackListBox_SelectedIndexChanged);
            // 
            // albumLabel
            // 
            this.albumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumLabel.Location = new System.Drawing.Point(306, 94);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.albumLabel.Size = new System.Drawing.Size(84, 17);
            this.albumLabel.TabIndex = 7;
            this.albumLabel.Text = "Album:";
            this.albumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // releasedLabel
            // 
            this.releasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releasedLabel.Location = new System.Drawing.Point(306, 127);
            this.releasedLabel.Name = "releasedLabel";
            this.releasedLabel.Size = new System.Drawing.Size(84, 17);
            this.releasedLabel.TabIndex = 8;
            this.releasedLabel.Text = "Raleased:";
            this.releasedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lengthLabel
            // 
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthLabel.Location = new System.Drawing.Point(306, 164);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(84, 23);
            this.lengthLabel.TabIndex = 9;
            this.lengthLabel.Text = "Length:";
            this.lengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // genresLabel
            // 
            this.genresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresLabel.Location = new System.Drawing.Point(306, 203);
            this.genresLabel.Name = "genresLabel";
            this.genresLabel.Size = new System.Drawing.Size(84, 17);
            this.genresLabel.TabIndex = 10;
            this.genresLabel.Text = "Genres:";
            this.genresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // albumTextBox
            // 
            this.albumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumTextBox.Location = new System.Drawing.Point(407, 94);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.ReadOnly = true;
            this.albumTextBox.Size = new System.Drawing.Size(167, 19);
            this.albumTextBox.TabIndex = 11;
            // 
            // releasedTextBox
            // 
            this.releasedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.releasedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.releasedTextBox.Location = new System.Drawing.Point(407, 127);
            this.releasedTextBox.Name = "releasedTextBox";
            this.releasedTextBox.ReadOnly = true;
            this.releasedTextBox.Size = new System.Drawing.Size(166, 19);
            this.releasedTextBox.TabIndex = 12;
            // 
            // lengtTextBox
            // 
            this.lengtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengtTextBox.Location = new System.Drawing.Point(407, 168);
            this.lengtTextBox.Name = "lengtTextBox";
            this.lengtTextBox.ReadOnly = true;
            this.lengtTextBox.Size = new System.Drawing.Size(167, 19);
            this.lengtTextBox.TabIndex = 13;
            // 
            // genresTextBox
            // 
            this.genresTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genresTextBox.Location = new System.Drawing.Point(407, 203);
            this.genresTextBox.Multiline = true;
            this.genresTextBox.Name = "genresTextBox";
            this.genresTextBox.ReadOnly = true;
            this.genresTextBox.Size = new System.Drawing.Size(167, 237);
            this.genresTextBox.TabIndex = 14;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "XML Files|*.xml";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.genresTextBox);
            this.Controls.Add(this.lengtTextBox);
            this.Controls.Add(this.releasedTextBox);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(this.genresLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.releasedLabel);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.trackListBox);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.artistComboBox);
            this.Controls.Add(this.loadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.ComboBox artistComboBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.ListBox trackListBox;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label releasedLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label genresLabel;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.TextBox releasedTextBox;
        private System.Windows.Forms.TextBox lengtTextBox;
        private System.Windows.Forms.TextBox genresTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

