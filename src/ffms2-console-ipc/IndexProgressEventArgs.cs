using System;

namespace ffms2.console.ipc
{
    [Serializable]
    public sealed class IndexProgressEventArgs : EventArgs
    {
        /// <summary>
        /// Current indexing progress
        /// </summary>
        public double Progress { get; private set; }

        public IndexProgressEventArgs(long current, long totalToIndex) { Progress = (double) current / totalToIndex; }
    }
}