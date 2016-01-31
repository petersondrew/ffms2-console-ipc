using System;

namespace ffms2.console.ipc
{
    [Serializable]
    public enum TrackType
    {
        Unknown = -1,
        Video,
        Audio,
        Data,
        Subtitle,
        Attachment
    }
}