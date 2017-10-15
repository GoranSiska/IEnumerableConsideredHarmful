using NUnit.Framework;
using System;
using System.Diagnostics;

namespace _05_OrderOfEvaluation
{
    [TestFixture]
    public class GivenNumbersService : IDisposable
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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (traceListener != null)
                {
                    traceListener.Dispose();
                }
            }
        }

        public void AssertProperNesting()
        {
            Assert.AreEqual("<GetNumbers_Outer>", traceListener.Log[0]);
            Assert.AreEqual("<GetNumbers_Inner>", traceListener.Log[1]);
            Assert.AreEqual("</GetNumbers_Inner>", traceListener.Log[2]);
            Assert.AreEqual("</GetNumbers_Outer>", traceListener.Log[3]);
        }

        #endregion

        [Test]
        public void WhenOperation_Materialized_InnerMethodIsProperlyNested()
        {
            var businessOperations = new NumbersService();

            businessOperations.GetNumbers_Materialized();

            AssertProperNesting();
        }

        [Test]
        public void WhenOperation_WithEnumerable_InnerMethodIsProperlyNested()
        {
            var businessOperations = new NumbersService();

            businessOperations.GetNumbers_WithEnumerable();

            AssertProperNesting();
        }

        [Test]
        public void WhenOperation_WithYield_InnerMethodIsProperlyNested()
        {
            var businessOperations = new NumbersService();

            businessOperations.GetNumbers_WithYield();

            AssertProperNesting();
        }

        [Test]
        public void WhenOperation_WithAction_InnerMethodIsProperlyNested()
        {
            var businessOperations = new NumbersService();
            var businessLogic = new Action<int>(n => 
            {
                //do business logic 
            });

            businessOperations.GetNumbers_WithAction(businessLogic);

            AssertProperNesting();
        }
    }
}
