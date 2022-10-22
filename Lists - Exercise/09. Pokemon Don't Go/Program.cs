using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
//Ely likes to play Pokemon Go a lot. But Pokemon Go bankrupted … So the developers made Pokemon Don’t Go out of depression. And so Ely
//now plays Pokemon Don’t Go. In Pokemon Don’t Go, when you walk to a certain pokemon, those closest to you, naturally get further, and
//those further from you, get closer.
//You will receive a sequence of integers, separated by spaces – the distances to the pokemon.Then you will begin receiving integers,
//which will correspond to indexes in that sequence.
//When you receive an index, you must remove the element at that index from the sequence (as if you’ve captured the pokemon).
//•	You must increase the value of all elements in the sequence, which are less or equal to the removed element, with the value of the
//removed element.
//•	You must decrease the value of all elements in the sequence, which are greater than the removed element, with the value of the
//removed element.
//If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.
//If the given index is greater than the last index of the sequence, remove the last element from the sequence, and copy the first element
//to its place.
//The increasing and decreasing of elements should be done in these cases, also. The element, whose value you should use is the removed
//element.
//The program ends when the sequence has no elements(there are no pokemon left for Ely to catch).
//Input
//•	On the first line of input, you will receive a sequence of integers, separated by spaces.
//•	On the next several lines you will receive integers – the indexes.
//Output
//•	When the program ends, you must print the summed value of all removed elements.
//Constrains
//•	The input data will consist only of valid integers in the range[-2.147.483.648, 2.147.483.647].
            List<int> pokemons = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            int sum = 0;
            while (pokemons.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int choosenPokemon = 0;
                if (index < 0)
                {
                    choosenPokemon = pokemons[0];
                    sum += choosenPokemon;
                    pokemons.RemoveAt(0);
                    ChangingValues(pokemons, choosenPokemon);
                    choosenPokemon = pokemons[pokemons.Count - 1];
                    pokemons.Insert(0, choosenPokemon);
                    Console.WriteLine(string.Join(" ", pokemons));
                    continue;
                }
                else if (index >= pokemons.Count)
                {
                    choosenPokemon = pokemons[pokemons.Count - 1];
                    sum += choosenPokemon;
                    pokemons.RemoveAt(pokemons.Count - 1);
                    ChangingValues(pokemons, choosenPokemon);
                    choosenPokemon = pokemons[0];
                    pokemons.Add(choosenPokemon);
                    Console.WriteLine(string.Join(" ", pokemons));
                    continue;
                }

                choosenPokemon = pokemons[index];
                sum += choosenPokemon;
                pokemons.RemoveAt(index);
                ChangingValues(pokemons, choosenPokemon);

                Console.WriteLine(string.Join(" ", pokemons));
            }
            Console.WriteLine(sum);
        }

        private static void ChangingValues(List<int> pokemons, int choosenPokemon)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i] <= choosenPokemon)
                {
                    pokemons[i] += choosenPokemon;
                }
                else
                {
                    pokemons[i] -= choosenPokemon;
                }
            }
        }
    }
}
