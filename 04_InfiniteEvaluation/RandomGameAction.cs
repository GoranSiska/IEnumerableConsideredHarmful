using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InfiniteEvaluation
{
    public class RandomGameAction : IEnumerable<GameActions>, IEnumerator<GameActions>
    {
        public GameActions Current { get; private set; }

        object IEnumerator.Current { get { return Current; } }

        private Random _random = new Random();
        private GameActions[] _gameActions;
        public RandomGameAction()
        {
            _gameActions = (GameActions[])Enum.GetValues(typeof(GameActions));
        } 

        public bool MoveNext()
        {
            Current = _gameActions[_random.Next(0, _gameActions.Length)];

            return true;
        }

        public void Reset()
        {
            //Do nothing
        }

        public void Dispose()
        {
            //Do nothing
        }

        public IEnumerator<GameActions> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public enum GameActions
    {
        Attack,
        Defend
    }
}
