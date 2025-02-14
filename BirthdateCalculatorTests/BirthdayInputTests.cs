using BirthdateCalculator;

namespace BirthdateCalculatorTests
{
    public class BirthdayInputTests
    {
        private BirthdayInput _birthdayInput;
        [SetUp]
        public void Setup()
        {
            _birthdayInput = new BirthdayInput();
        }


        [Test]
        public void If_null_is_provided_should_throw_exception()
        {
            Assert.Throws<ArgumentNullException>(() => _birthdayInput.UserInputConverter(null));
        }

        [Test]
        public void If_empty_string_is_provided_should_throw_exception()
        {
            Assert.Throws<InvalidDataException>(() => _birthdayInput.UserInputConverter(""));
        }

        [Test]
        public void If_invalid_input_is_provided_should_throw_exception()
        {
            Assert.Throws<InvalidDataException>(() => _birthdayInput.UserInputConverter("asdfasdfa"));
        }

        [Test]
        public void if_invalid_numbers_are_provided_should_throw_exception()
        {
            Assert.Throws<InvalidDataException>(() => _birthdayInput.UserInputConverter("12312313"));
        }

        [Test]
        public void if_invalid_month_is_provided_should_throw_exception()
        {
            Assert.Throws<InvalidDataException>(() => _birthdayInput.UserInputConverter("1231/23/13"));
        }

        [Test]
        public void if_invalid_day_is_provided_should_throw_exception()
        {
            Assert.Throws<InvalidDataException>(() => _birthdayInput.UserInputConverter("2020/12/83"));
        }

        [Test]
        public void if_correct_date_is_provided_should_return_datetime_value()
        {
            var birthdate = _birthdayInput.UserInputConverter("1983/08/23");
            Assert.That(new DateTime(1983, 8, 23), Is.EqualTo(birthdate));
        }
    }
}