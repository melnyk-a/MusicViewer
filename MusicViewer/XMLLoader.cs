using System.Collections.Generic;
using System.Xml;

namespace MusicViewer
{
    internal sealed class XMLLoader
    {
        public IEnumerable<Track> Load(string path)
        {
            IList<Track> loadedTracks = new List<Track>();
            IList<string> albums = new List<string>();
            IList<string> artists = new List<string>();
            IList<string> genres = new List<string>();

            var document = new XmlDocument();
            document.Load(path);

            XmlNode albumsNode = document.DocumentElement.FirstChild;
            foreach (XmlNode album in albumsNode)
            {
                albums.Add(album.Attributes["name"].Value);
            }
            XmlNode artistsNode = albumsNode.NextSibling;
            foreach (XmlNode artist in artistsNode)
            {
                artists.Add(artist.Attributes["name"].Value);
            }
            XmlNode genresNode = artistsNode.NextSibling;
            foreach (XmlNode genre in genresNode)
            {
                genres.Add(genre.Attributes["name"].Value);
            }
            XmlNode tracksNode = genresNode.NextSibling;
            
            foreach (XmlNode track in tracksNode)
            {
                var attributes = track.Attributes;
                int.TryParse(track.Attributes["album-id"].Value, out int albumID);
                int.TryParse(track.Attributes["artist-id"].Value, out int artistID);
                string length = track.Attributes["length"].Value;
                string name = track.Attributes["name"].Value;
                string released = track.Attributes["released"].Value; ;
                
                var trackGenresNode = track.FirstChild;
                List<Genre> trackGenres = new List<Genre>();
               
                foreach (XmlNode genre in trackGenresNode)
                {
                    int.TryParse(genre.Attributes["genre-id"].Value, out int genreID);
                    trackGenres.Add(new Genre(genres[genreID - 1]));
                }
                trackGenres.Sort(new GenreComperer());
                loadedTracks.Add(
                    new Track(
                        name, 
                        artists[artistID - 1], 
                        length, 
                        albums[albumID - 1], 
                        released, 
                        trackGenres
                        ));
            }
            return loadedTracks;
        }
    }
}