using System;
namespace UserRegistrationUsingRegEX
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome To User registration Problem");
            Console.Write("Enter The Email:");
            String email = Console.ReadLine();

            if (UserRegistration.validate(email))
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }


    }
}