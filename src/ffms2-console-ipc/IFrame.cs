using System;
using System.Collections.ObjectModel;
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
        //byte[] Data { get; }
        ReadOnlyCollection<IntPtr> Data { get; }
        ReadOnlyCollection<int> DataLengths { get; }
        bool Unwrapped { get; }
        //Bitmap ExtractBitmap();
        //IFrame Unwrap();
    }
}