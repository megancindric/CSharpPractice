using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class Sandbox
    {

        // member variables

        // constructor
        public Sandbox() {}
        // member methods
        public void StringInterpolator()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"So, your first name is {firstName}, and your last name is {lastName}, so your full name must be {fullName}! ");
            Console.ReadLine();
        }

        public void TemperatureConverter()
        {
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
        public void RandomNumberGenerator()
        {
            Console.WriteLine("Generating 5 random numbers...");
            Random rnd = new Random();
            int rnd_num;

            for (int i = 0; i < 5; i++)
            {
                rnd_num = rnd.Next(0, 10);

                if (rnd_num >= 0 && rnd_num <= 2)
                {
                    Console.WriteLine($"{i + 1}: The number was between 0 and 2!  It was {rnd_num}!");
                }
                else if (rnd_num >= 3 && rnd_num <= 5)
                {
                    Console.WriteLine($"{i + 1}: The number was between 3 and 5!  It was {rnd_num}!");
                }
                else if (rnd_num >= 6 && rnd_num <= 8)
                {
                    Console.WriteLine($"{i + 1}: The number was between 6 and 8!  It was {rnd_num}!");
                }
                else
                {
                    Console.WriteLine($"{i + 1}: The number was either 9 or 10!  It was {rnd_num}!");
                }
            }
        }
        public void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PasswordChecker()
        {
            string password = "Password1!";
            Console.WriteLine("Please enter your account password:");
            string userGuess = Console.ReadLine();
            int guessesLeft = 5;
            while (password != userGuess && guessesLeft > 0)
            {
                Console.WriteLine("Incorrect Password!  Please try again:");
                guessesLeft--;
                userGuess = Console.ReadLine();
                if (userGuess == password)
                {
                    Console.WriteLine("Access Granted.");
                    Console.ReadLine();
                }
            }
        }
    }
}
