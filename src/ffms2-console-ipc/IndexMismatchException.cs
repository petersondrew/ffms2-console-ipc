using System;

namespace ffms2.console.ipc
{
    public class IndexMismatchException : Exception
    {
        public string File { get; private set; }
        public string Index { get; private set; }

        public IndexMismatchException(string message) : base(message) { }

        public IndexMismatchException(string message, string file, string index) : base(message)
        {
            File = file;
            Index = index;
        }
    }
}