using System;
using System.Diagnostics;

namespace _05_OrderOfEvaluation
{
    // Define other methods and classes here
    public class Context : IDisposable
    {
        private static int count;
        private readonly string _methodName;
        public Context(string methodName)
        {
            _methodName = methodName;
            Debug.IndentLevel = count;
            Debug.WriteLine("<" + _methodName + ">");
            count++;
        }

        public void Dispose()
        {
            count--;
            Debug.IndentLevel = count;
            Debug.WriteLine("</" + _methodName + ">");
        }
    }
}
