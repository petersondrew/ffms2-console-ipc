using System;

namespace ffms2.console.ipc
{
    [Serializable]
    public class TimeBase
    {
        public long Numerator { get; }
        public long Denominator { get; }

        public TimeBase(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }
    }
}