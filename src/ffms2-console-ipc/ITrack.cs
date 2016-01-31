namespace ffms2.console.ipc
{
    public interface ITrack
    {
        int TrackNumber { get; }
        TrackType Type { get; }
        int FrameCount { get; }
        TimeBase TimeBase { get; }
    }
}
