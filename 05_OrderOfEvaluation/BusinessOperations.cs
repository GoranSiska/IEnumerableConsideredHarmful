using System.Collections.Generic;
using System.Linq;

namespace _05_OrderOfEvaluation
{
    public class BusinessOperations
    {
        #region Materialized

        public void MainMaterialized()
        {
            foreach (var number in OuterMethod_1())
            {
                //do business logic
            }
        }

        protected IEnumerable<int> OuterMethod_1()
        {
            using (var context = new Context())
            {
                return InnerMethod_1();
            }
        }

        protected List<int> InnerMethod_1()
        {
            using (var context = new Context())
            {
                return Enumerable.Range(0, 10).ToList();
            }
        }

        #endregion

        #region WithEnumerable

        public void MainWithEnumerable()
        {
            foreach (var number in OuterMethod_2())
            {
                //do business logic
            }
        }

        protected IEnumerable<int> OuterMethod_2()
        {
            using (var context = new Context())
            {
                return InnerMethod_2();
            }
        }

        public IEnumerable<int> InnerMethod_2()
        {
            using (var context = new Context())
            {
                return Enumerable.Range(0, 10);
            }
        }

        #endregion

        #region WithYield

        public void MainWithYield()
        {
            foreach (var number in OuterMethod_3())
            {
                //do business logic
            }
        }

        protected IEnumerable<int> OuterMethod_3()
        {
            using (var context = new Context())
            {
                return InnerMethod_3();
            }
        }

        public IEnumerable<int> InnerMethod_3()
        {
            using (var context = new Context())
            {
                foreach (var number in Enumerable.Range(0, 10))
                {
                    yield return number;
                }
            }
        }

        #endregion
    }
}
