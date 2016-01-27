using System;
using System.Collections.ObjectModel;
using System.Drawing;

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
        public ReadOnlyCollection<IntPtr> Data { get; }
        public ReadOnlyCollection<int> DataLengths { get; }

        public Frame() { }

        public Frame(int frameNumber, long pts, long filePos, bool keyFrame, int repeatPicture)
        {
            FrameNumber = frameNumber;
            PTS = pts;
            FilePos = filePos;
            KeyFrame = keyFrame;
            RepeatPicture = repeatPicture;
        }
        
        public Frame(int frameNumber, long pts, long filePos, bool keyFrame, int repeatPicture, char frameType,
            Size resolution, ReadOnlyCollection<IntPtr> data, ReadOnlyCollection<int> dataLengths) : this(frameNumber, pts, filePos, keyFrame, repeatPicture)
        {
            FrameType = frameType;
            Resolution = resolution;
            if (resolution.Height <= 0) return;
            Data = data;
            DataLengths = dataLengths;
        }
    }
}