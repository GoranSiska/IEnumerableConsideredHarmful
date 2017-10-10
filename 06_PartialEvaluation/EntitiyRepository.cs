using System.Collections.Generic;
using System.Linq;

namespace _06_PartialEvaluation
{
    public class EntitiyRepository
    {
        public IEnumerable<int> ConvertAndStore(IEnumerable<int> items)
        {
            AreItemsStored = false;
            var convertedItems = new List<int>();
            foreach(var convertedItem in items.Select(Convert))
            {
                convertedItems.Add(convertedItem);
                yield return convertedItem;
            }
            Store(convertedItems);
        }

        public int Convert(int item)
        {
            return item * 10;
        }

        public bool AreItemsStored { get; private set; }
        public void Store(IEnumerable<int> items)
        {
            AreItemsStored = true;
        }
    }
}
