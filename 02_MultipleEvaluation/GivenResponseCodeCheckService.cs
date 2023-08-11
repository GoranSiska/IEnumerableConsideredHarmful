using NUnit.Framework;
using System.Collections.Generic;

namespace _02_MultipleEvaluation
{
    [TestFixture]
    public partial class GivenResponseCodeCheckService
    {

        [Test]
        public void WhenCheckErrorsInResponseCodes_WithErrorCode_ReturnsFalse()
        {
            var responseCodes = new List<int> { 200, 200, 404 };
            var log = new TestLog();
            var businessOperations = new ResponseCodeCheckService(log);

            var result = businessOperations.CheckErrorsInResponseCodes(responseCodes);

            Assert.IsFalse(result);
        }

        [Test]
        public void WhenCheckErrorsInResponseCodes_WithErrorCode_GetErrorsCalledOnce()
        {
            var responseCodes = new List<int> { 200, 200, 404 };
            var log = new TestLog();
            var businessOperations = new ResponseCodeCheckService(log);

            var result = businessOperations.CheckErrorsInResponseCodes(responseCodes);

            Assert.AreEqual(1, log["GetErrorCodes"]);
        }

        [Test]
        public void WhenCheckErrorsInResponseCodes_WithErrorCode_SomeLongRunningOperationCalledOnce()
        {
            var responseCodes = new List<int> { 200, 200, 404 };
            var log = new TestLog();
            var businessOperations = new ResponseCodeCheckService(log);

            var result = businessOperations.CheckErrorsInResponseCodes(responseCodes);

            Assert.AreEqual(1, log["SomeLongRunningOperation"]);
        }
    }
}
