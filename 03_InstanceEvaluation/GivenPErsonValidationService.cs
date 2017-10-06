using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InstanceEvaluation
{
    [TestFixture]
    public class GivenPersonValidationService
    {
        [Test]
        public void Test101()
        {
            //Shlemiel The Painter
            PersonDto[] personDtos = new[]
            {
               new PersonDto { Name = "Goran" },
               new PersonDto { Name = "Simon" },
               new PersonDto { Name = "0138x" }
            };
            var personValidationService = new PersonValidationService();

            var result = personValidationService.HaveErrors(personDtos);

            Assert.AreEqual(true, result);
        }
    }
}
