using NUnit.Framework;

namespace _03_InstanceEvaluation
{
    [TestFixture]
    public class GivenPersonValidationService
    {
        [Test]
        public void WhenValidatingPersonsWithErrors_HasErrorsReturnsTrue()
        {
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
