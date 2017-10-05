using System.Collections.Generic;
using System.Diagnostics;

namespace _05_OrderOfEvaluation
{
    public class TestTraceListener : TraceListener
    {
        public TestTraceListener()
        {
            Log = new List<string>();
        }

        public List<string> Log { get; private set; }

        public override void WriteLine(string message)
        {
            Log.Add(message);
        }

        public override void Write(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
