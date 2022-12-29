using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive input until you receive "END".Find what data type is the input. Possible data types are:
            //•	Integer
            //•	Floating point 
            //•	Characters
            //•	Boolean
            //•	Strings
            //Print the result in the following format: "{input} is {data type} type"

            int decimalPointCounter = 0;
            int minusSignCounter = 0;
            string input = Console.ReadLine();
            while (input != "END" && input != "end")
            {
                bool isItInteger = false;
                bool isItFloat = false;
                bool isItCharacter = false;
                bool isItBoolean = false;
                bool isItString = false;
                int inputLength = input.Length;


                if (input[0] >= '0' && input[0] <= '9' || input[0] == '-' || 
                    input[0] == '.' || input[0] == ',')
                {
                    for (int i = 0; i <= inputLength - 1; i++)
                    {
                        char index = input[i];
                        bool isItNumber = index >= '0' && index <= '9' || index == '-' || 
                            index == '.' || index == ',' || index == '/' || index == '+' || index == '*';
                        if (isItNumber && index == '-')
                        {
                            minusSignCounter++;
                            if (i != 0) // this prevents acknoledging a number type with minus sign in the middle
                            {
                                isItInteger = false;
                                isItFloat = false;
                                break;
                            }
                        }
                        if (isItNumber && (index == '.' || index == ',' || index == '/'))
                        {
                            decimalPointCounter++;
                        }
                        if (isItNumber && decimalPointCounter <= 1 && minusSignCounter <= 1)
                        {
                            if (index == '.' || index == ',' || index == '/')
                            {
                                isItFloat = true;
                                isItInteger = false;
                                if (i == inputLength - 1) // this prevents acknoledging floating number type for no digits, after the poin/comma
                                {
                                    isItInteger = false;
                                    isItFloat = false;
                                    break;
                                }
                            }
                            else
                            {
                                if (!isItFloat)
                                {
                                    isItInteger = true;
                                }
                            }
                        }
                        else if (!(isItNumber && decimalPointCounter <= 1 && minusSignCounter <= 1)|| !isItNumber)
                        {
                            isItInteger = false;
                            isItFloat = false;
                            break; // it is NOT a number. Continue with identification of the data type...
                        }
                    }
                }
                if (input == "true" || input == "TRUE" || input == "True" || input == "TRue" || 
                    input == "TRUe" || input == "tRUE" || input == "trUE" || input == "truE" || 
                    input == "TRuE" || input == "TrUE" || input == "false" || input == "FALSE" || 
                    input == "False" || input == "FALSe" || input == "FALse" || input == "FAlse" || 
                    input == "falsE" || input == "falSE" || input == "faLSE" || input == "fALSE" || 
                    input == "FalsE" || input == "FAlSE" || input == "fAlSe" || input == "FaLsE")
                {
                    isItBoolean = true;
                }
                if (inputLength == 1 && !(isItFloat || isItInteger))
                {
                    isItCharacter = true;
                }
                if (inputLength != 1 && !(isItFloat || isItInteger) && input != "END" && input != "end")
                {
                    isItString = true;
                }


                if (isItInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (isItFloat)
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (isItBoolean)
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (isItCharacter)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (isItString)
                {
                    Console.WriteLine($"{input} is string type");
                }
                decimalPointCounter = 0;
                minusSignCounter = 0;
                input = Console.ReadLine();
            }
         }
    }
}
