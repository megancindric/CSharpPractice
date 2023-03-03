using System.Xml.Serialization;

namespace CSharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== User Input & String Interpolation ==========\n    ");

            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"So, your first name is {firstName}, and your last name is {lastName}, so your full name must be {fullName}! ");
            Console.ReadLine();

            Console.WriteLine("========== Temperature Conversion ==========\n");

                decimal tempF;
                decimal tempC;
                string repeat = "";
                while (repeat != "n")
            {
                Console.WriteLine("Press 1 to convert Fahrenheit to Celsius\n\nOr, press 2 to convert Celsius to Fahrenheit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Please enter a temperature in Fahrenheit to convert:");
                    tempF = Convert.ToDecimal(Console.ReadLine());
                    tempC = Math.Round(((tempF - 32) * 5 / 9), 2);
                    Console.WriteLine($"\n{tempF} degrees Fahrenheit is the same as {tempC} degrees Celsius");

                }
                else
                {
                    Console.WriteLine("Please enter a temperature in Celsius to convert:");
                    tempC = Convert.ToDecimal(Console.ReadLine());
                    tempF = Math.Round(((tempC - 32) * 5 / 9), 2);
                    Console.WriteLine($"\n{tempC} degrees Celsius is the same as {tempF} degrees Fahrenheit\n");
                }
                Console.WriteLine("Would you like to try again? (y/n)");
                repeat = Console.ReadLine().ToLower();
            }
                

       
        }
    }
}