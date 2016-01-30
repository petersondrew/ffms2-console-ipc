using System;
using System.Runtime.Serialization;

namespace ffms2.console.ipc.Exceptions
{
    [Serializable]
    public class IndexAccessException : FFMSException
    {
        static string FormatMessage(int frameNumber, int trackNumber)
        {
            return $"Error retrieving frame {frameNumber} in track {trackNumber} from index";
        }

        static string FormatMessage(long position, int trackNumber)
        {
            return $"Error retrieving frame at position {position} in track {trackNumber} from index";
        }

        static string FormatMessage(double time, int trackNumber)
        {
            return $"Error retrieving frame at PTS {TimeSpan.FromMilliseconds(time)} in track {trackNumber} from index";
        }

        public IndexAccessException()
        {
        }

        public IndexAccessException(string message) : base(message)
        {
        }

        public IndexAccessException(int frameNumber, int trackNumber) : this(FormatMessage(frameNumber, trackNumber))
        {
        }

        public IndexAccessException(long position, int trackNumber) : this(FormatMessage(position, trackNumber))
        {
        }

        public IndexAccessException(double time, int trackNumber) : this(FormatMessage(time, trackNumber))
        {
        }

        public IndexAccessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public IndexAccessException(int frameNumber, int trackNumber, Exception innerException)
            : this(FormatMessage(frameNumber, trackNumber), innerException)
        {
        }

        public IndexAccessException(long position, int trackNumber, Exception innerException)
            : this(FormatMessage(position, trackNumber), innerException)
        {
        }

        public IndexAccessException(double time, int trackNumber, Exception innerException)
            : this(FormatMessage(time, trackNumber), innerException)
        {
        }

        public IndexAccessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}