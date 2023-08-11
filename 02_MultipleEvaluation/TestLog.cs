using System.Collections.Generic;

namespace _02_MultipleEvaluation
{
    public partial class GivenResponseCodeCheckService
    {
        class TestLog : ILog
        {
            private Dictionary<string, int> _methodCallLog;
            public TestLog()
            {
                _methodCallLog = new Dictionary<string, int>();
            }
            
            public int this[string key] 
            {
                get
                {
                    return _methodCallLog[key];
                }
            }
            public void Log(string message)
            {
                if(!_methodCallLog.ContainsKey(message))
                {
                    _methodCallLog.Add(message, 0);
                }
                _methodCallLog[message]++;   
            }
        }
    }
}
