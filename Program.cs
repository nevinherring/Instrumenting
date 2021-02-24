using System;
using static System.Console;
using System.Diagnostics;
using System.IO;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            // text writer is buffered, so this options calls
            // Flush() on all listeners after writing
            Trace.AutoFlush = true;
            Debug.WriteLine("Debug says, I am Watching!");
            Trace.WriteLine("Trace says, I am watching!");
        }
    }
}
