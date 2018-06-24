namespace MusicViewer
{
    internal sealed class TrackWrapper
    {
        private readonly Track track;

        public TrackWrapper(Track track)
        {
            this.track = track;
        }

        public Track Track => track;

        public override string ToString()
        {
            return track.Name;
        }
    }
}