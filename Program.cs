using System;
namespace UserRegistrationUsingRegEX
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome To User registration Problem");
            Console.WriteLine("Enter the last name");
            String LName = Console.ReadLine();

            if (UserRegistration.Validate(LName))
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