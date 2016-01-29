using System;
using System.Runtime.Serialization;

namespace ffms2.console.ipc.Exceptions
{
    [Serializable]
    public class IndexCreationException : FFMSException
    {
        public IndexCreationException()
        {
        }

        public IndexCreationException(string message) : base(message)
        {
        }

        public IndexCreationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IndexCreationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}