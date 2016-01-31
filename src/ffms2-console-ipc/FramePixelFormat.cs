using System;
using System.Diagnostics.CodeAnalysis;

namespace ffms2.console.ipc
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [Serializable]
    public enum FramePixelFormat
    {
        None,
        IYUV,
        YV12,
        YUY2,
        RGB24,
        BGR24
    }
}