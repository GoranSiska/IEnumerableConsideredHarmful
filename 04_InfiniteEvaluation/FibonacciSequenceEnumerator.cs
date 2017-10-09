using System.Collections;
using System.Collections.Generic;

namespace _04_InfiniteEvaluation
{
    public class FibonacciSequenceEnumerator : IEnumerator<long>
    {
        public FibonacciSequenceEnumerator()
        {
            ((IEnumerator)this).Reset();
        }
        
        private long _last;
        private long _current;
        long IEnumerator<long>.Current { get { return _current; } }
        object IEnumerator.Current { get { return ((IEnumerator)this).Current; } }

        bool IEnumerator.MoveNext()
        {
            if (_current == -1)
            {
                _current = 0;
            }
            else if (_current == 0)
            {
                _current = 1;
            }
            else
            {
                _current = _current + _last;
                _last = _current - _last;
            }

            return true;
        }

        void IEnumerator.Reset()
        {
            _current = -1;
        }

        public void Dispose()
        {
            //Do nothing
        }
    }
}
