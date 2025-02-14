using BirthdateCalculator;

namespace BirthdateCalculatorTests
{
    public class BirthdayCheckerTests
    {
        private BirthDayChecker _birthdayChecker;

        [SetUp]
        public void Setup()
        {
            _birthdayChecker = new BirthDayChecker();
        }

        [Test]
        public void Should_return_true_if_birthday_is_today()
        {
            Assert.IsTrue(_birthdayChecker.IsItToday(DateTime.Today));
        }

        [Test]
        public void Should_return_true_if_date_and_month_matches_today()
        {
            Assert.IsTrue(_birthdayChecker.IsItToday(new DateTime(DateTime.Today.Year - 25, DateTime.Today.Month, DateTime.Today.Day)));
        }

        [Test]
        public void Should_return_false_if_month_does_not_match()
        {
            var birthdate = new DateTime(DateTime.Today.Year - 2, DateTime.Today.Month - 1, DateTime.Today.Day);
            Assert.IsFalse(_birthdayChecker.IsItToday(birthdate));
        }


        [Test]
        public void Should_return_false_if_day_does_not_match()
        {
            var birthdate = new DateTime(DateTime.Today.Year - 2, DateTime.Today.Month, DateTime.Today.Day - 1);
            Assert.IsFalse(_birthdayChecker.IsItToday(birthdate));
        }
    }
}
