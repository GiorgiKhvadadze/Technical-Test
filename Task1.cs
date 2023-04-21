using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string myUsername = "giorgiKhvadadze";
            string myPassword = "khvadadze";
            int attemptsNum = 5;

            Console.WriteLine("Enter your username and password:");

            while (attemptsNum > 0)
            {
                Console.Write("Username: ");
                string inputUsername = Console.ReadLine();
                Console.Write("Password: ");
                string inputPassword = Console.ReadLine();

                if (inputUsername == myUsername && inputPassword == myPassword)
                {
                    Console.WriteLine("Success!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password! Please try again.");
                    attemptsNum--;
                }
            }

            Console.WriteLine("Sorry, you have run out of attempts!");
        }
    }
}