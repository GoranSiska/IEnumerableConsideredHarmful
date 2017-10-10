using NUnit.Framework;
using System.Linq;

namespace _06_PartialEvaluation
{
    [TestFixture]
    public class GivenEntitiyRepository
    {
        [Test]
        public void WhenConvertAndStore_DataIsStored()
        {
            var repository = new EntitiyRepository();
            Assert.IsFalse(repository.AreItemsStored, "AreItemsStored should be false when no items are stored!");
            var items = Enumerable.Range(0, 10);

            repository.ConvertAndStore(items).ToList();
            //repository.ConvertAndStore(items).Take(1).ToList();
            //repository.ConvertAndStore(items).Where(i=>i==1).ToList();
            //repository.ConvertAndStore(items).Any(i => i == 1);
            //repository.ConvertAndStore(items).All(i => i == 2);
            //repository.ConvertAndStore(items).TakeWhile(i=>i<2).ToList();
            //repository.ConvertAndStore(items).SkipWhile(i=>i<2).ToList();
            //repository.ConvertAndStore(items).First();
            //repository.ConvertAndStore(items).Last();
            //repository.ConvertAndStore(items).ElementAt(1);

            Assert.IsTrue(repository.AreItemsStored);
        }
    }
}
