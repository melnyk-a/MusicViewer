using System.Collections.Generic;

namespace MusicViewer
{

    internal sealed class GenreComperer : IComparer<Genre>
    {
        public int Compare(Genre first, Genre second)
        {
            return first.Name.CompareTo(second.Name);
        }
    }
}