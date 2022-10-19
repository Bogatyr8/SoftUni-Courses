using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that checks. if a given password is valid.
//The password validation rules are:
//•	It should contain 6 – 10 characters(inclusive)
//•	It should contain only letters and digits
//•	It should contain at least 2 digits
//If it is not valid, for any unfulfilled rule print the corresponding message:
//•	"Password must be between 6 and 10 characters"
//•	"Password must consist only of letters and digits"
//•	"Password must have at least 2 digits"
            string input = Console.ReadLine();
            bool isPassLngthValid = IsPasswordLengthValid(input);
            bool isPassAlphaNumrc = IsPasswordAlphaNumeric(input);
            bool hasTwoDigits = IsPasswordContainingAtLeastTwoDigits(input);

            if (!isPassLngthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPassAlphaNumrc)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isPassLngthValid && isPassAlphaNumrc && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordLengthValid(string password) 
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsPasswordContainingAtLeastTwoDigits(string password)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }

            return digitsCount >= 2;
        }
    }
}
