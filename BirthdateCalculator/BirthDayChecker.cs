namespace BirthdateCalculator
{
    public class BirthDayChecker
    {
        public bool IsItToday(DateTime dateTime)
        {
            return dateTime.Day == DateTime.Now.Day && dateTime.Month == DateTime.Now.Month;
        }
    }
}
