using BirthdateCalculator;

namespace BirthdateCalculator
{
    public class Entrypoint
    {
        static void Main()
        {
            // Keep the console open until user presses Ctrl + C
            Console.WriteLine("Press Ctrl + C to exit...");
            while (true)
            {
                Console.Write("Enter your birthdate (YYYY/MM/DD): ");
                string? userValue = Console.ReadLine();
                UserAgeCalculator(userValue);

                // Wait for the user to press Ctrl + C to exit
                Console.ReadKey(true);  // Does not display key press in the console
            }
        }


        private static void UserAgeCalculator(string? userValue)
        {
            try
            {
                BirthdayInput input = new();
                var ageCalculator = new AgeCalculator();
                var birthDate = input.UserInputConverter(userValue);
                var age = ageCalculator.Calculate(birthDate);
                Console.WriteLine(new AgeMessageHandler().Display(age));
                if (new BirthDayChecker().IsItToday(birthDate))
                {
                    Console.WriteLine(Messages.BIRTHDAY_MESSAGE);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

