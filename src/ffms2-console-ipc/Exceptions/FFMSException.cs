using System;
using System.Runtime.Serialization;

namespace ffms2.console.ipc.Exceptions
{
    [Serializable]
    public class FFMSException : ApplicationException
    {
        public FFMSException()
        {
        }

        public FFMSException(string message) : base(message)
        {
        }

        public FFMSException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public FFMSException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}