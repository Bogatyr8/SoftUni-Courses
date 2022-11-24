using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
//A mighty battle is coming.In the stormy nether realms, demons are fighting against each other for supremacy in a duel from which
//only one will survive.
//Your job, however, is not so exciting. You are assigned to sign in all the participants in the nether realm's mighty battle's
//demon book, which of course is sorted alphabetically. 
//A demon's name contains his health and his damage. 
//The sum of the asci codes of all characters(excluding numbers(0 - 9), arithmetic symbols('+', '-', '*', '/') and delimiter
//dot('.')) gives a demon's total health. 
//The sum of all numbers in his name forms his base damage.Note that you should consider the plus '+' and minus '-'
//signs(e.g. + 10 is 10 and -10 is -10).However, there are some symbols('*' and '/') that can further alter the base damage by
//multiplying or dividing it by 2(e.g. in the name "m15*/c-5.0", the base damage is 15 + (-5.0) = 10 and then you need to multiply
//it by 2(e.g. 10 * 2 = 20) and then divide it by 2(e.g. 20 / 2 = 10)).
//So, multiplication and division are applied only after all numbers are included in the calculation and in the order they appear
//in the name.
//You will get all demons on a single line, separated by commas and zero or more blank spaces.Sort them in alphabetical order
//and print their names along with their health and damage.
//Input
//The input will be read from the console.The input consists of a single line containing all demon names separated by commas
//and zero or more spaces in the format: "{demon name}, {demon name}, … {demon name}"
//Output
//Print all demons sorted by their name in ascending order, each on a separate line in the format:
//•	"{demon name} - {health points} health, {damage points} damage"
//Constraints
//•	A demon's name will contain at least one character.
//•	A demon's name cannot contain blank spaces ' ' or commas ', '.
//•	A floating - point number will always have digits before and after its decimal separator.
//•	Number in a demon's name is considered everything that is a valid integer or floating point number (with dot '.' used as
//separator). For example, all these are valid numbers: '4', ' + 4', ' - 4', '3.5', ' + 3.5', ' - 3.5'.
            string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"(?<health>[A-Za-z])|(?<damage>((\+|-)?\d+(\.\d+)?)|[/*])";
            Regex regex = new Regex(pattern);
            StringBuilder sbHealth= new StringBuilder();
            string name = string.Empty;
            string healthString = string.Empty;
            string damageString = string.Empty;

            List<Demon> listOFDemons = new List<Demon>();
            foreach (var entity in input)
            {
                MatchCollection lettersAndDigits = regex.Matches(entity);
                List<string> damageList = new List<string>();

                foreach (Match item in lettersAndDigits)
                {

                    name = entity;
                    string sign = item.Value;
                    bool check = char.TryParse(sign, out char temp);
                    if (check && ((temp >= 'A' && temp <= 'Z') || (temp >= 'a' && temp <= 'z')))
                    {
                        sbHealth.Append(sign);
                    }
                    else
                    {
                        damageList.Add(sign);
                    }
                }
                healthString = sbHealth.ToString();
                sbHealth.Clear();
                int health = CalculateHealth(healthString);
                double damage = CalculateDamage(damageList);
                Demon demon = new Demon(name, health, damage);
                listOFDemons.Add(demon);
            }

            listOFDemons = listOFDemons.OrderBy(x => x.Name).ToList();

            foreach (var item in listOFDemons)
            {
                Console.WriteLine($"{item.Name} - {item.Health} health, {item.Damage:f2} damage");
            }

        }
        static int CalculateHealth(string healthString)
        {
            int sum = 0;
            for (int i = 0; i < healthString.Length; i++)
            {
                sum += healthString[i];
            }
            return sum;
        }
        static double CalculateDamage(List<string> damageList)
        {
            double damage = 0.0;
            List<string> multiplyAndDivide = new List<string>();

            for (int i = 0; i < damageList.Count; i++)
            {
                if (damageList[i] == "*" || damageList[i] == "/")
                {
                    multiplyAndDivide.Add(damageList[i]);
                    damageList.Remove(damageList[i]);
                    i--;
                }
                else
                {
                    damage += double.Parse(damageList[i]);
                }
            }

            foreach (var item in multiplyAndDivide)
            {
                if (item =="*")
                {
                    damage *= 2;
                }
                else if (item == "/")
                {
                    damage /= 2;
                }
            }

            return damage;
        }

    }

    public class Demon
    {
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
}
