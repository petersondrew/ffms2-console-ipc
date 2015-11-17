using System.Drawing;

namespace ffms2.console.ipc
{
    public interface IFrame
    {
        int FrameNumber { get; }
        long PTS { get; }
        long FilePos { get; }
        bool KeyFrame { get; }
        int RepeatPicture { get; }
        char FrameType { get; }
        Size Resolution { get; }
        byte[] Data { get; }
        bool Unwrapped { get; }
        Bitmap ExtractBitmap();
        IFrame Unwrap();
    }
}