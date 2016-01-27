using System.Diagnostics.CodeAnalysis;

namespace ffms2.console.ipc
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
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