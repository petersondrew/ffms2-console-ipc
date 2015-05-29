using System.Drawing;

namespace ffms2.console.ipc
{
    public interface IFrame
    {
        int FrameNumber { get; }
        long PTS { get; }
        char FrameType { get; }
        byte[] BitmapBytes { get; }
        Bitmap ExtractBitmap();
    }
}