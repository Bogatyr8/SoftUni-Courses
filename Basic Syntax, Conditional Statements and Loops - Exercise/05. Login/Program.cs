using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int usernameLength = username.Length;
            int attempt = 1;
            bool isHeBlocked = false;
            for (int i = usernameLength - 1; i >= 0; i--)
            {

                password += $"{username[i]}";
            }

            string input = Console.ReadLine();
            while (input != password)
            {
                if (input == password || attempt == 4)
                {
                    isHeBlocked = true;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                attempt++;
                input = Console.ReadLine();
            }
            if (!isHeBlocked)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else if (isHeBlocked)
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
