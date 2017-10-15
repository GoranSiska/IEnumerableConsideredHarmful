using System;
using System.Collections;
using System.Collections.Generic;

namespace _04_InfiniteEvaluation
{
    public class FibonacciSequenceEnumerator : IEnumerator<long>
    {
        public FibonacciSequenceEnumerator()
        {
           this.Reset();
        }
        
        private long _last;
        private long _current;
        public long Current { get { return _current; } }
        object IEnumerator.Current { get { return this.Current; } }

        public bool MoveNext()
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

        public void Reset()
        {
            _current = -1;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            //Do nothing
        }
    }
}
