namespace BirthdateCalculator
{
    public class AgeMessageHandler
    {
        public string Display(Age age)
        {
            return age.Years switch
            {
                <= 0 when age.Days == 0 => Messages.DATE_IS_TODAY,
                <= 0 when age.Days <= -1 => Messages.DATE_AFTER_TODAY,
                >= 100 => Messages.AGE_IS_100,
                _ => string.Format("You age is {0} days and in years {1}", age.Days, Math.Round(age.Years)),
            };
        }
    }
}
