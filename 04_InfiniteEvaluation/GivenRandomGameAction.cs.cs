using NUnit.Framework;
using System.Linq;
namespace _04_InfiniteEvaluation
{
    [TestFixture]
    public class GivenRandomGameAction
    {
        [Test, Timeout(2000)]
        public void Test101()
        {
            var randomGameAction = new RandomGameAction();

            var result = randomGameAction.Count();

            Assert.AreEqual(2, result);
        }
    }
}
