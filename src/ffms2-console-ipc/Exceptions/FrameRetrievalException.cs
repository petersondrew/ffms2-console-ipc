using System;
using System.Runtime.Serialization;

namespace ffms2.console.ipc.Exceptions
{
    [Serializable]
    public class FrameRetrievalException : FFMSException
    {
        public FrameRetrievalException()
        {
        }

        public FrameRetrievalException(string message) : base(message)
        {
        }

        public FrameRetrievalException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public FrameRetrievalException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}