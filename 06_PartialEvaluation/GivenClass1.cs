using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PartialEvaluation
{
    [TestFixture]
    public class GivenClass1
    {
        [Test]
        public void Test101()
        {
            var c = new Class1();
            //c.Test().ToList();
            //c.Test().Take(1).ToList();
            //c.Test().Where(i=>i==1).ToList();
            //c.Test().Any(i => i == 1);
            //c.Test().All(i => i == 2);
            //c.Test().TakeWhile(i=>i<2).ToList();
            //c.Test().SkipWhile(i=>i<1).ToList();
            //c.Test().First();
            //c.Test().Last();
            //c.Test().ElementAt(1);
        }
    }
}
