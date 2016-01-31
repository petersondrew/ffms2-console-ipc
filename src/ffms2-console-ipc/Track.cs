using System;

namespace ffms2.console.ipc
{
    [Serializable]
    public class Track : ITrack
    {
        public int TrackNumber { get; }
        public TrackType Type { get; }
        public int FrameCount { get; }
        public TimeBase TimeBase { get; }

        public Track(int trackNumber, TrackType type, int frameCount, TimeBase timeBase)
        {
            TrackNumber = trackNumber;
            Type = type;
            FrameCount = frameCount;
            TimeBase = timeBase;
        }
    }
}