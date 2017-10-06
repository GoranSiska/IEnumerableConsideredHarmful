using System.Collections.Generic;
using System.Linq;

namespace _05_OrderOfEvaluation
{
    public class NumbersService
    {
        #region Materialized

        public void GetNumbers_Materialized()
        {
            foreach (var number in GetNumbers_Outer_1())
            {
                //do business logic
            }
        }

        protected IEnumerable<int> GetNumbers_Outer_1()
        {
            using (var context = new Context())
            {
                return GetNumbers_Inner_1();
            }
        }

        protected List<int> GetNumbers_Inner_1()
        {
            using (var context = new Context())
            {
                return Enumerable.Range(0, 10).ToList();
            }
        }

        #endregion

        #region WithEnumerable

        public void GetNumbers_WithEnumerable()
        {
            foreach (var number in GetNumbers_Outer_2())
            {
                //do business logic
            }
        }

        protected IEnumerable<int> GetNumbers_Outer_2()
        {
            using (var context = new Context())
            {
                return GetNumbers_Inner_2();
            }
        }

        public IEnumerable<int> GetNumbers_Inner_2()
        {
            using (var context = new Context())
            {
                return Enumerable.Range(0, 10);
            }
        }

        #endregion

        #region WithYield

        public void GetNumbers_WithYield()
        {
            foreach (var number in GetNumbers_Outer_3())
            {
                //do business logic
            }
        }

        protected IEnumerable<int> GetNumbers_Outer_3()
        {
            using (var context = new Context())
            {
                return GetNumbers_Inner_3();
            }
        }

        public IEnumerable<int> GetNumbers_Inner_3()
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
