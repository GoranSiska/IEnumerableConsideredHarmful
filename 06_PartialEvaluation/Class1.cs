using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PartialEvaluation
{
    public class Class1
    {
        public IEnumerable<int> Test()
        {
            yield return 1;
            Action1();
            yield return 2;
            Action2();
        }

        public void Action1()
        {
            Debug.WriteLine("1");
        }

        public void Action2()
        {
            Debug.WriteLine("2");
        }
    }
}
