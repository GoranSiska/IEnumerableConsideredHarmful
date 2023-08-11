using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02_MultipleEvaluation
{
    public class ResponseCodeCheckService
    {
        private ILog _log;
        public ResponseCodeCheckService(ILog log)
        {
            _log = log;
        }
        public bool CheckErrorsInResponseCodes(List<int> responseCodes)
        {
            //var errorCodes = GetErrorCodes().ToList();
            return responseCodes
                .All(responseCode => GetErrorCodes() //errorCodes
                    .All(errorCode => errorCode != responseCode));
        }

        public virtual IEnumerable<int> GetErrorCodes()
        {
            _log.Log("GetErrorCodes");
            SomeLongRunningOperation();

            yield return 401;
            yield return 404;
            yield return 500;
        }

        public virtual void SomeLongRunningOperation()
        {
            _log.Log("SomeLongRunningOperation");
            //simulating long running operation
            Thread.Sleep(500);
        }
    }
}
