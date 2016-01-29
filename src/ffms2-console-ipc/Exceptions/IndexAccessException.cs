using System;
using System.Runtime.Serialization;

namespace ffms2.console.ipc.Exceptions
{
    [Serializable]
    public class IndexAccessException : FFMSException
    {
        public IndexAccessException()
        {
        }

        public IndexAccessException(string message) : base(message)
        {
        }

        public IndexAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IndexAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}