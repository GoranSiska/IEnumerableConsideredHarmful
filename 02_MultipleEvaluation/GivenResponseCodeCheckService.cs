using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace _02_MultipleEvaluation
{
    [TestFixture]
    public class GivenResponseCodeCheckService
    {
        [Test, Timeout(1000)] //, Timeout(1000)
        public void WhenCheckErrorsInResponseCodes_WithErrorCode_ReturnsFalse()
        {
            var responseCodes = new List<int> { 200, 200, 404 };
            var businessOperations = new ResponseCodeCheckService();

            var result = businessOperations.CheckErrorsInResponseCodes(responseCodes);

            Assert.IsFalse(result);
        }

        [Test]
        public void WhenCheckErrorsInResponseCodes_WithErrorCode_GetErrorsCalledOnce()
        {
            var responseCodes = new List<int> { 200, 200, 404 };
            var businessOperationsMock = new Mock<ResponseCodeCheckService>();
            businessOperationsMock.CallBase = true;
            
            var result = businessOperationsMock.Object.CheckErrorsInResponseCodes(responseCodes);

            businessOperationsMock.Verify(bo=>bo.GetErrorCodes(), Times.Once);
        }

        [Test]
        public void WhenCheckErrorsInResponseCodes_WithErrorCode_SomeLongRunningOperationCalledOnce()
        {
            var responseCodes = new List<int> { 200, 200, 404 };
            var businessOperationsMock = new Mock<ResponseCodeCheckService>();
            businessOperationsMock.CallBase = true;

            var result = businessOperationsMock.Object.CheckErrorsInResponseCodes(responseCodes);

            businessOperationsMock.Verify(bo => bo.SomeLongRunningOperation(), Times.Once);
        }
    }
}
