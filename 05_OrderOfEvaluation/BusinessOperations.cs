using System.Collections.Generic;
using System.Linq;

namespace _05_OrderOfEvaluation
{
    public class BusinessOperations
    {
        public void Main()
        {
            OuterMethod().ToList();
        }

        public IEnumerable<int> OuterMethod()
        {
            using (var context = new Context(Helpers.GetCaller()))
            {
                return InnerMethod3();
            }
        }

        public List<int> InnerMethod()
        {
            using (var context = new Context(Helpers.GetCaller()))
            {
                return Enumerable.Range(0, 10).ToList();
            }
        }

        public IEnumerable<int> InnerMethod2()
        {
            using (var context = new Context(Helpers.GetCaller()))
            {
                return Enumerable.Range(0, 10);
            }
        }

        public IEnumerable<int> InnerMethod3()
        {
            using (var context = new Context(Helpers.GetCaller()))
            {
                foreach (var number in Enumerable.Range(0, 10))
                {
                    yield return number;
                }
            }
        }
    }
}
