using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ffms2.console.ipc
{
    [Serializable]
    public class Frame : IFrame
    {
        public int FrameNumber { get; private set; }
        public long PTS { get; private set; }
        public char FrameType { get; private set; }

        //[NonSerialized]
        //Bitmap internalBitmap;

        public byte[] BitmapBytes { get; private set; }

        public Frame() { }

        public Frame(int frameNumber, long pts, char frameType, Bitmap bitmap)
        {
            FrameNumber = frameNumber;
            PTS = pts;
            FrameType = frameType;
            using (var stream = new MemoryStream())
            {
                bitmap.Save(stream, ImageFormat.Bmp);
                BitmapBytes = stream.ToArray();
            }
        }

        public Bitmap ExtractBitmap()
        {
            // Keep the stream alive https://msdn.microsoft.com/en-us/library/z7ha67kw.aspx
            return new Bitmap(new MemoryStream(BitmapBytes));
        }
    }
}