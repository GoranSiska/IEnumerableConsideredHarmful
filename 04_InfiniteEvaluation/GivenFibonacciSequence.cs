using NUnit.Framework;
using System.Linq;

namespace _04_InfiniteEvaluation
{
    [TestFixture]
    public class GivenFibonacciSequence
    {
        [Test]
        public void WhenTakingFirstTenValues_ReturnsFirstToTenthFibonacciValues()
        {
            var fibonacciSequence = new FibonacciSequence();

            var result = fibonacciSequence.Take(10).ToArray();

            var expectedSequence = new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            CollectionAssert.AreEqual(expectedSequence, result);
        }

        [Test]
        public void WhenSkippingFiveAndTakingFirstTenValues_ReturnsFifthToFifteenthFibonacciValues()
        {
            var fibonacciSequence = new FibonacciSequence();

            var result = fibonacciSequence.Skip(5).Take(10).ToArray();

            var expectedSequence = new long[] { 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
            CollectionAssert.AreEqual(expectedSequence, result);
        }

        [Test, Timeout(2000)]
        public void WhenCountingValues_ReturnsInfinite()
        {
            var fibonacciSequence = new FibonacciSequence();

            var result = fibonacciSequence.FirstOrDefault(n=>n==6);

            Assert.Greater(result, 100);
        }
    }


}
