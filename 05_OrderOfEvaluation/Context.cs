using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _05_OrderOfEvaluation
{
    public class Context : IDisposable
    {
        private readonly string _methodName;
        public Context([CallerMemberName] string methodName = null)
        {
            _methodName = methodName;
            Debug.WriteLine("<" + _methodName + ">");
            Debug.Indent();
        }

        public void Dispose()
        {
            Debug.Unindent();
            Debug.WriteLine("</" + _methodName + ">");
        }
    }
}
