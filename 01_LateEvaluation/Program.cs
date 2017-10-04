using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LateEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            var functions = new List<Func<int>>();

            foreach (var number in Enumerable.Range(0, 10))
            {
                functions.Add(() => number);
            }

            #region Foreach actually

            //var numbers = Enumerable.Range(0, 10).GetEnumerator();
            //try
            //{
            //    int current;
            //    while (numbers.MoveNext())
            //    {
            //        current = numbers.Current;
            //        functions.Add(() => current);
            //    }
            //}
            //finally
            //{
            //    //Do nothing
            //}
            
            #endregion

            Console.WriteLine(
                functions
                    .Select(x => x().ToString())
                    .Aggregate((a, n) => a += "," + n));

            Console.ReadLine();
        }
    }
}
