using System;
namespace UserRegistrationUsingRegEX
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome To User registration Problem");
            Console.WriteLine("Enter the Mobile Number");
            String mob = Console.ReadLine();

            if (UserRegistration.validate(mob))
            {
                Console.WriteLine("Valid Mobile number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile number");
            }
        }


    }
}