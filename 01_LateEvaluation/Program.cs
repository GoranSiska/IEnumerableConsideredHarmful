using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_LateEvaluation
{
    class Program
    {
#pragma warning disable CRR0026 // Unused member
        static void Main(string[] args)
#pragma warning restore CRR0026 // Unused member
        {
            var functions = new List<Func<int>>();

            foreach (var number in Enumerable.Range(0, 10))
            {
                functions.Add(() => number);
            }

            #region Foreach actually

            //var enumerator = Enumerable.Range(0, 10).GetEnumerator();
            //try
            //{
            //    int current;
            //    while (enumerator.MoveNext())
            //    {
            //        current = enumerator.Current;
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
                    .Select(function => function().ToString())
                    .Aggregate((aggregate, number) => aggregate + "," + number));

            Console.ReadLine();
        }
    }
}
