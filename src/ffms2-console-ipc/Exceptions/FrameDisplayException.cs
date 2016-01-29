using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ffms2.console.ipc.Exceptions
{
    [Serializable]
    public class FrameDisplayException : FFMSException
    {
        public FrameDisplayException()
        {
        }

        public FrameDisplayException(string message) : base(message)
        {
        }

        public FrameDisplayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public FrameDisplayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
