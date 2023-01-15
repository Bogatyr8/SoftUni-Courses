namespace _08._SoftUni_Party
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            //There is a party in SoftUni.Many guests are invited and there are two types of them: VIP and
            //Regular.When a guest comes, check if he / she exists in any of the two reservation lists.
            //All reservation numbers will be with the length of 8 chars.
            //All VIP numbers start with a digit.
            //First, you will be receiving the reservation numbers of the guests. You can also receive 2
            //possible commands:
            //•	"PARTY" – After this command, you will begin receiving the reservation numbers of the
            //people, who came to the party.
            //•	"END" – The party is over and you have to stop the program and print the appropriate
            //output.
            //In the end, print the count of the guests who didn't come to the party, and afterward,
            //print their reservation numbers. the VIP guests must be first.
            HashSet<string> listForVIP = new HashSet<string>();
            HashSet<string> reservationList = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (input.Length == 8 && !CheckPlate(reservationList, input) && !IsItVIP(input))
                {
                    reservationList.Add(input);
                }

                if (input.Length == 8 && int.TryParse(input[0].ToString(), out int value) && !CheckVIP(listForVIP, input) && IsItVIP(input))
                {
                    listForVIP.Add(input);
                }

            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (input.Length == 8 && CheckPlate(reservationList, input))
                {
                    reservationList.Remove(input);
                }

                if (input.Length == 8 && int.TryParse(input[0].ToString(), out int value) && CheckPlate(listForVIP, input))
                {
                    listForVIP.Remove(input);
                }
            }

            Console.WriteLine($"{reservationList.Count + listForVIP.Count}");
            foreach (var vip in listForVIP)
            {
                Console.WriteLine(vip);
            }
            foreach (var ordinary in reservationList)
            {
                Console.WriteLine(ordinary);
            }
        }

        private static bool CheckPlate(HashSet<string> reservationList, string ID)
        {
            return reservationList.Contains(ID);
        }
        private static bool CheckVIP(HashSet<string> listForVIP, string ID)
        {
            return listForVIP.Contains(ID);
        }

        private static bool IsItVIP(string input)
        {
            return int.TryParse(input[0].ToString(), out int value);
        }
    }
}
