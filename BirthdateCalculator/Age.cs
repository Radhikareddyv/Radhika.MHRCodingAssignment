namespace BirthdateCalculator
{
    public class Age
    {
        private const double DaysInYearConsideringLeapYears = 365.25;

        public Age(double days)
        {
            this.Days = days;
        }

        public double Days { get; }

        public double Years => Days / DaysInYearConsideringLeapYears;
    }
}
