using NUnit.Framework;
using System.Diagnostics;

namespace _05_OrderOfEvaluation
{
    [TestFixture]
    public class GivenBusinessOperations
    {
        #region Test infrastructure

        protected TestTraceListener traceListener;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            traceListener = new TestTraceListener();
            Debug.Listeners.Add(traceListener);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Debug.Listeners.Remove(traceListener);
        }

        [TearDown]
        public void TearDown()
        {
            traceListener.Log.Clear();
        }

        #endregion

        [Test]
        public void WhenMainMaterialized_InnerMethodIsProperlyNested()
        {
            var businessOperations = new BusinessOperations();
            businessOperations.MainMaterialized();

            Assert.AreEqual("<OuterMethod_1>", traceListener.Log[0]);
            Assert.AreEqual("<InnerMethod_1>", traceListener.Log[1]);
            Assert.AreEqual("</InnerMethod_1>", traceListener.Log[2]);
            Assert.AreEqual("</OuterMethod_1>", traceListener.Log[3]);
        }

        [Test]
        public void WhenMainWithEnumerable_InnerMethodIsProperlyNested()
        {
            var businessOperations = new BusinessOperations();
            businessOperations.MainWithEnumerable();

            Assert.AreEqual("<OuterMethod_2>", traceListener.Log[0]);
            Assert.AreEqual("<InnerMethod_2>", traceListener.Log[1]);
            Assert.AreEqual("</InnerMethod_2>", traceListener.Log[2]);
            Assert.AreEqual("</OuterMethod_2>", traceListener.Log[3]);
        }

        [Test]
        public void WhenMainWithyield_InnerMethodIsProperlyNested()
        {
            var businessOperations = new BusinessOperations();
            businessOperations.MainWithYield();

            Assert.AreEqual("<OuterMethod_3>", traceListener.Log[0]);
            Assert.AreEqual("<InnerMethod_3>", traceListener.Log[1]);
            Assert.AreEqual("</InnerMethod_3>", traceListener.Log[2]);
            Assert.AreEqual("</OuterMethod_3>", traceListener.Log[3]);
        }
    }
}
