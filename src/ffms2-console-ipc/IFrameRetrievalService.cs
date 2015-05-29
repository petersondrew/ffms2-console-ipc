using System;

namespace ffms2.console.ipc
{
    public interface IFrameRetrievalService
    {
        bool Indexed { get; }

        bool Index(string file, bool useCached = true, string indexCacheFile = null);

        event EventHandler<IndexProgressEventArgs> IndexProgress;

        void SetFrameOutputFormat(int width, int height, FrameResizeMethod frameResizeMethod);

        IFrame GetFrame(int trackNumber, int frameNumber);

        IFrame GetFrameAtPosition(int trackNumber, long position);

        IFrame GetFrameAtTime(int trackNumber, double time);
    }
}