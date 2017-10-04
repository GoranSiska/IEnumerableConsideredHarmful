using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OrderOfEvaluation
{
    [TestFixture]
    public class BusinessOperationsTests
    {
        [Test]
        public void Test101()
        {
            var traceListener = new TestTraceListener();
            Debug.Listeners.Add(traceListener);

            var c = new BusinessOperations();
            c.Main();

            Assert.AreEqual(traceListener.Log[0], "<OuterMethod>");
            Assert.AreEqual(traceListener.Log[1], "<InnerMethod>");
            Assert.AreEqual(traceListener.Log[2], "</InnerMethod>");
            Assert.AreEqual(traceListener.Log[3], "</OuterMethod>");
        }
    }

    public class TestTraceListener : TraceListener
    {
        public TestTraceListener()
        {
            Log = new List<string>();
        }

        public List<string> Log { get; private set; }

        public override void Write(string message)
        {
            var current = Log.Last();
            Log.RemoveAt(Log.Count - 1);
            Log.Add(current + message);
        }

        public override void WriteLine(string message)
        {
            Log.Add(message);
        }
    }
}
