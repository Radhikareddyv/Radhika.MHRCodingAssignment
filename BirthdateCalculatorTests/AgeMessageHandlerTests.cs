using BirthdateCalculator;

namespace BirthdateCalculatorTests
{
    public class AgeMessageHandlerTests
    {
        private AgeMessageHandler _displayMessages;

        [SetUp]
        public void SetUp()
        {
            _displayMessages = new AgeMessageHandler();
        }

        [Test]
        public void if_the_age_is_above_100_then_display_message()
        {
            Assert.That(_displayMessages.Display(new Age(38000)), Is.EqualTo(Messages.AGE_IS_100));
        }

        [Test]
        public void if_the_date_is_after_today_then_display_message()
        {
            Assert.That(_displayMessages.Display(new Age(-10)), Is.EqualTo(Messages.DATE_AFTER_TODAY));
        }

        [Test]
        public void if_date_is_today()
        {
            Assert.That(_displayMessages.Display(new Age(0)), Is.EqualTo(Messages.DATE_IS_TODAY));
        }
    }
}