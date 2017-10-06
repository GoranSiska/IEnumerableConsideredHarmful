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
            _methodName = methodName.Substring(0, methodName.Length - 2);
            Debug.WriteLine("<" + _methodName + ">");
            Debug.Indent();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Debug.Unindent();
                Debug.WriteLine("</" + _methodName + ">");
            }
        }
    }
}
