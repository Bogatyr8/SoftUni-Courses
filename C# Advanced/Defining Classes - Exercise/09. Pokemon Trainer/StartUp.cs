//Define a class Trainer and a class Pokemon. 
//Trainers have:
//Name
//Number of badges
//A collection of pokemon
//Pokemon have:
//Name
//Element
//Health
//All values are mandatory. Every Trainer starts with 0 badges.
//You will be receiving lines until you receive the command "Tournament". Each line will carry information
//about a pokemon and the trainer who caught it in the format:
//"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
//TrainerName is the name of the Trainer who caught the pokemon. Trainers' names are unique.
//After receiving the command "Tournament", you will start receiving commands until the "End" command is
//received. They can contain one of the following:
//"Fire"
//"Water"
//"Electricity"
//For every command, you must check if a trainer has at least 1 pokemon with the given element. If he does,
//he receives 1 badge. Otherwise, all of his pokemon lose 10 health. If a pokemon falls to 0 or less health,
//he dies and must be deleted from the trainer's collection. In the end, you should print all of the
//trainers, sorted by the number of badges they have in descending order (if two trainers have the same
//amount of badges, they should be sorted by order of appearance in the input) in the format: 
//"{trainerName} {badges} {numberOfPokemon}"
using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer;

public class StartUp
{
    public static void Main(string[] args)
    {
        Dictionary<string, Trainer> trainers = new();

        GetPokemons(trainers);

        Competition(trainers);

        Dictionary<string, Trainer> competition = 
            trainers.OrderByDescending(t => t.Value.Badges).ToDictionary(x => x.Key, y => y.Value);

        foreach (var trainer in competition)
        {
            Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.NumberOfPokemons}");
        }

    }

    private static void Competition(Dictionary<string, Trainer> trainers)
    {
        string inputArg;
        while ((inputArg = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                trainer.Value.Challenge(inputArg);
            }
        }
    }

    private static void GetPokemons(Dictionary<string, Trainer> trainers)
    {
        string inputArg;
        while ((inputArg = Console.ReadLine()) != "Tournament")
        {
            string[] input = inputArg
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string trainerName = input[0];
            string pokemonName = input[1];
            string pokemonElement = input[2];
            int pokemonHealth = int.Parse(input[3]);
            Pokemon pokemon = new(pokemonName, pokemonElement, pokemonHealth);
            if (!trainers.ContainsKey(trainerName))
            {
                trainers.Add(trainerName, new(trainerName));
            }
            trainers[trainerName].AddPokemon(pokemon);
        }
    }
}