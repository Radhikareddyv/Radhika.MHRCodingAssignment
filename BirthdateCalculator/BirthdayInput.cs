namespace BirthdateCalculator
{
    public class BirthdayInput
    {
        public DateTime UserInputConverter(string? userInput)
        {
            if (userInput == null)
            {
                throw new ArgumentNullException("Please enter date");
            }

            bool isCorrectDateTime = DateTime.TryParse(userInput, out DateTime birthDate);
            return !isCorrectDateTime ? throw new InvalidDataException("Invalid DateTime") : birthDate;
        }
    }
}
