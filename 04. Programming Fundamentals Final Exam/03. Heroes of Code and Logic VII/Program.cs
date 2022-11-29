using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            //You got your hands on the most recent update on the best MMORPG of all time – Heroes of Code and Logic.You want to play it all
            //day long!So cancel all other arrangements and create your party!
            //On the first line of the standard input, you will receive an integer n – the number of heroes that you can choose for your
            //party. On the next n lines, the heroes themselves will follow with their hit points and mana points separated by a single
            //space in the following format: 
            //"{hero name} {HP} {MP}"
            //- HP stands for hit points and MP for mana points
            //-a hero can have a maximum of 100 HP and 200 MP
            //After you have successfully picked your heroes, you can start playing the game.You will be receiving different commands, each
            //on a new line, separated by " – ", until the "End" command is given.
            //There are several actions that the heroes can perform:
            //"CastSpell – {hero name} – {MP needed} – {spell name}"
            //•	If the hero has the required MP, he casts the spell, thus reducing his MP.Print this message: 
            //o "{hero name} has successfully cast {spell name} and now has {mana points left} MP!"
            //•	If the hero is unable to cast the spell print:
            //o "{hero name} does not have enough MP to cast {spell name}!"
            //   "TakeDamage – {hero name} – {damage} – {attacker}"
            //•	Reduce the hero HP by the given damage amount.If the hero is still alive (his HP is greater than 0) print:
            //o "{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"
            //•	If the hero has died, remove him from your party and print:
            //o "{hero name} has been killed by {attacker}!"
            //"Recharge – {hero name} – {amount}"
            //•	The hero increases his MP.If it brings the MP of the hero above the maximum value(200), MP is increased to 200. (the MP
            //can't go over the maximum value).
            //•	Print the following message:
            //o "{hero name} recharged for {amount recovered} MP!"
            //"Heal – {hero name} – {amount}"
            //•	The hero increases his HP.If a command is given that would bring the HP of the hero above the maximum value(100), HP is
            //increased to 100(the HP can't go over the maximum value).
            //•	Print the following message:
            //o "{hero name} healed for {amount recovered} HP!"
            //Input
            //•	On the first line of the standard input, you will receive an integer n
            //•	On the following n lines, the heroes themselves will follow with their hit points and mana points separated by a space in
            //the following format
            //•	You will be receiving different commands, each on a new line, separated by " – ", until the "End" command is given
            //Output
            //•	Print all members of your party who are still alive, in the following format(their HP / MP need to be indented 2 spaces):
            //"{hero name}
            //HP: { current HP}
            //MP: { current MP}"
            //Constraints
            //•	The starting HP / MP of the heroes will be valid, 32 - bit integers will never be negative or exceed the respective limits.
            //•	The HP/ MP amounts in the commands will never be negative.
            //•	The hero names in the commands will always be valid members of your party. No need to check that explicitly.
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            GettingHeroes(heroes);
            PlayingWithHeroes(heroes);
            PrintTheRemainingHeroes(heroes);

        }

        private static void GettingHeroes(Dictionary<string, int[]> heroes)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] heroStats = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string heroName = heroStats[0];
                int heroHP = int.Parse(heroStats[1]);
                int heroMP = int.Parse(heroStats[2]);

                heroes[heroName] = new int[2] { heroHP, heroMP };
            }
        }

        private static void PlayingWithHeroes(Dictionary<string, int[]> heroes)
        {
            string inputString;
            while ((inputString = Console.ReadLine()) != "End")
            {
                string[] activity = inputString
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string action = activity[0];
                string heroName = activity[1];
                if (action == "CastSpell")
                {
                    int spellMana = int.Parse(activity[2]);
                    string spell = activity[3];
                    if (heroes[heroName][1] >= spellMana)
                    {
                        heroes[heroName][1] -= spellMana;
                        Console.WriteLine($"{heroName} has successfully cast {spell} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spell}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(activity[2]);
                    string attacker = activity[3];
                    heroes[heroName][0] -= damage;
                    if (heroes[heroName][0] >= 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (action == "Recharge")
                {
                    int manaBoost = int.Parse(activity[2]);
                    heroes[heroName][1] += manaBoost;
                    if (heroes[heroName][1] > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {manaBoost - (heroes[heroName][1] - 200)} MP!");
                        heroes[heroName][1] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {manaBoost} MP!");
                    }
                }
                else if (action == "Heal")
                {
                    int healthBoost = int.Parse(activity[2]);
                    heroes[heroName][0] += healthBoost;
                    if (heroes[heroName][0] > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {healthBoost - (heroes[heroName][0] - 100)} HP!");
                        heroes[heroName][0] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {healthBoost} HP!");
                    }
                }
            }
        }

        private static void PrintTheRemainingHeroes(Dictionary<string, int[]> heroes)
        {
            foreach (var heroe in heroes)
            {
                Console.WriteLine($"{heroe.Key}\n  HP: {heroe.Value[0]}\n  MP: {heroe.Value[1]}");
            }
        }
    }
}
