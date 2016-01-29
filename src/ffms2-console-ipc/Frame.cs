using System;
using System.Drawing;

namespace ffms2.console.ipc
{
    [Serializable]
    public class Frame : IFrame
    {
        public int TrackNumber { get; }
        public int FrameNumber { get; }
        public long PTS { get; }
        public long FilePos { get; }
        public bool KeyFrame { get; }
        public int RepeatPicture { get; }
        public char FrameType { get; }
        public Size Resolution { get; }

        public Frame()
        {
        }

        public Frame(int trackNumber, int frameNumber, long pts, long filePos, bool keyFrame, int repeatPicture)
        {
            TrackNumber = trackNumber;
            FrameNumber = frameNumber;
            PTS = pts;
            FilePos = filePos;
            KeyFrame = keyFrame;
            RepeatPicture = repeatPicture;
        }

        public Frame(int trackNumber, int frameNumber, long pts, long filePos, bool keyFrame, int repeatPicture,
            char frameType,
            Size resolution) : this(trackNumber, frameNumber, pts, filePos, keyFrame, repeatPicture)
        {
            FrameType = frameType;
            Resolution = resolution;
        }
    }
}