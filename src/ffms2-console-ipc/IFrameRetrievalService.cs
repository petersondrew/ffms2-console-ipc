using System;
using System.Collections.Generic;

namespace ffms2.console.ipc
{
    public interface IFrameRetrievalService
    {
        bool Indexed { get; }

        bool Index(string file, bool useCached = true, string alternateIndexCacheFileLocation = null,
            string videoCodec = null);

        event Action<IndexProgressEventArgs> IndexProgress;

        Exception LastException { get; }

        /// <summary>
        /// Set the seek handling mode for new video sources
        /// </summary>
        /// <param name="mode">The seek handling mode to use</param>
        /// <remarks>
        /// As video sources are cached, you must set the seek handling mode before retrieving any frames
        /// </remarks>
        void SetSeekHandling(SeekHandling mode);

        void SetFrameOutputFormat(int width = 0, int height = 0,
            FrameResizeMethod frameResizeMethod = FrameResizeMethod.Bicubic,
            FramePixelFormat pixelFormat = FramePixelFormat.YV12);

        /// <summary>
        /// Retrieve a List of all frames in the specified track
        /// </summary>
        /// <param name="trackNumber">The track to retrieve frames for</param>
        /// <returns></returns>
        List<IFrame> GetFrames(int trackNumber);

        IFrame GetFrame(int trackNumber, int frameNumber);

        IFrame GetFrameAtPosition(int trackNumber, long position);

        IFrame GetFrameAtTime(int trackNumber, double time);

        IFrame DisplayFrame(IFrame frame, IntPtr windowId);
    }
}