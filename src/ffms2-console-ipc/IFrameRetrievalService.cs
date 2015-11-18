using System;
using System.Collections.Generic;

namespace ffms2.console.ipc
{
    public interface IFrameRetrievalService
    {
        bool Indexed { get; }

        bool Index(string file, bool useCached = true, string alternateIndexCacheFileLocation = null, string videoCodec = null);

        event Action<IndexProgressEventArgs> IndexProgress;

        Exception LastException { get; }

        void SetFrameOutputFormat(int width, int height, FrameResizeMethod frameResizeMethod);

        IFrame GetFrame(int trackNumber, int frameNumber);

        List<IFrame> GetFrameInfos(int trackNumber);

        IFrame GetFrameAtPosition(int trackNumber, long position);

        IFrame GetFrameAtTime(int trackNumber, double time);
    }
}