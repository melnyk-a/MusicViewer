using System.Collections.Generic;

namespace MusicViewer
{
    internal sealed class Track
    {
        public Track(
            string name, 
            string artist, string length, 
            string album, 
            string released, 
            IEnumerable<Genre> genres
            )
        {
            Name = name;
            Artist = artist;
            Length = length;
            Album = album;
            Released = released;
            Genres = genres;
        }
        public string Album { get; }

        public string Artist { get; }

        public IEnumerable<Genre> Genres { get; }

        public string Length { get; }

        public string Name { get; }
        
        public string Released { get; }
    }
}