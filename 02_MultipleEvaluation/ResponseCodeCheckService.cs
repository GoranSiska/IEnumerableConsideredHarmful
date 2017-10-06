using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _02_MultipleEvaluation
{
    public class ResponseCodeCheckService
    {
        public bool CheckErrorsInResponseCodes(List<int> responseCodes)
        {
            //var errorCodes = GetErrorCodes();
            return responseCodes
                .All(responseCode => GetErrorCodes() //errorCodes
                    .All(errorCode => errorCode != responseCode));
        }

        public virtual IEnumerable<int> GetErrorCodes()
        {
            SomeLongRunningOperation();

            yield return 401;
            yield return 404;
            yield return 500;
        }

        public virtual void SomeLongRunningOperation()
        {
            //simulating long running operation
            Thread.Sleep(500);
        }
    }
}
