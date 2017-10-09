using System.Collections;
using System.Collections.Generic;

namespace _04_InfiniteEvaluation
{
    public class FibonacciSequence : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            return new FibonacciSequenceEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
