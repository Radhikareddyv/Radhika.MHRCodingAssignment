namespace BirthdateCalculator
{
    public class AgeCalculator
    {
        public Age Calculate(DateTime birthDate)
        {
            TimeSpan ageInDays = DateTime.Today - birthDate;
            return new Age(ageInDays.TotalDays);
        }
    }
}
