using System;
namespace UserRegistrationUsingRegEX
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome To User registration Problem");
            Console.WriteLine("Enter the Password");
            String pw = Console.ReadLine();

            if (UserRegistration.validate(pw))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }


    }
}