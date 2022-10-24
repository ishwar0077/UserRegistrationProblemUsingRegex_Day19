using System;
namespace UserRegistrationUsingRegEX
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome To User registration Problem");

            Console.WriteLine("Enter the first name");
            String FName = Console.ReadLine();

            if (UserRegistration.Validate(FName))
            {
                Console.WriteLine("Valid Name");
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }


    }
}