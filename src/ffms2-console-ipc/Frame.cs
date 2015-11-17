using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ffms2.console.ipc
{
    [Serializable]
    public class Frame : IFrame
    {
        public int FrameNumber { get; }
        public long PTS { get; }
        public long FilePos { get; }
        public bool KeyFrame { get; }
        public int RepeatPicture { get; }
        public char FrameType { get; }
        public Size Resolution { get; }
        public byte[] Data { get; }
        public bool Unwrapped { get; }

        public Frame() { }

        Frame(IFrame other)
        {
            // Copy constructor for remoting unwrap
            FrameNumber = other.FrameNumber;
            PTS = other.PTS;
            FilePos = other.FilePos;
            KeyFrame = other.KeyFrame;
            RepeatPicture = other.RepeatPicture;
            FrameType = other.FrameType;
            Resolution = other.Resolution;
            Data = other.Data;
            Unwrapped = true;
        }

        public Frame(int frameNumber, long pts, long filePos, bool keyFrame, int repeatPicture)
        {
            FrameNumber = frameNumber;
            PTS = pts;
            FilePos = filePos;
            KeyFrame = keyFrame;
            RepeatPicture = repeatPicture;
            Unwrapped = false;
        }

        public Frame(int frameNumber, long pts, long filePos, bool keyFrame, int repeatPicture, char frameType,
            Size resolution, IntPtr data, int dataLength) : this(frameNumber, pts, filePos, keyFrame, repeatPicture)
        {
            FrameType = frameType;
            Resolution = resolution;
            if (resolution.Height <= 0) return;
            Data = new byte[dataLength*resolution.Height];
            Marshal.Copy(data, Data, 0, dataLength*resolution.Height);
        }

        public unsafe Bitmap ExtractBitmap()
        {
            if (!Unwrapped)
                throw new Exception("You must unwrap the proxied instance first");

            if (Resolution.Height < 1 || Resolution.Width < 1)
                throw new Exception("Output format was not set properly or encoded resolution is invalid");

            fixed (byte* ptr = Data)
            {
                return new Bitmap(Resolution.Width, Resolution.Height, Resolution.Width * 4, PixelFormat.Format32bppArgb, (IntPtr) ptr);
            }
        }

        public IFrame Unwrap()
        {
            return Unwrapped ? this : new Frame(this);
        }
    }
}