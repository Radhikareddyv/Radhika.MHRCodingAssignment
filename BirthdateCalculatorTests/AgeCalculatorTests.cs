using BirthdateCalculator;

namespace BirthdateCalculatorTests
{
    public class AgeCalculatorTests
    {
        private AgeCalculator _ageCalculator;

        [SetUp]
        public void SetUp()
        {
            _ageCalculator = new AgeCalculator();
        }

        [Test]
        public void calculate_age()
        {
            var age = _ageCalculator.Calculate(new DateTime(DateTime.Now.Year - 40, DateTime.Now.Month, DateTime.Now.Day));
            Assert.That(age.Years, Is.EqualTo(40));
        }

        [Test]
        public void calculate_age_even_it_is_future_date()
        {
            var age = _ageCalculator.Calculate(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1));
            Assert.That(age.Days, Is.EqualTo(-1));
        }
    }
}
