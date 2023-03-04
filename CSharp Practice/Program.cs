using System.Xml.Serialization;

namespace CSharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sandbox sandbox = new Sandbox();

            Console.WriteLine("========== User Input & String Interpolation ==========\n    ");

            sandbox.StringInterpolator();
            


            Console.WriteLine("========== Temperature Conversion ==========\n");

            sandbox.TemperatureConverter();

            Console.WriteLine("\n========== Random Number Generation ==========\n");

            sandbox.RandomNumberGenerator();

            Console.WriteLine("\n========== FizzBuzz ==========\n");

            sandbox.FizzBuzz();

            Console.WriteLine("\n========== Password Validator ==========\n");

            sandbox.PasswordChecker();
        }
    }
}