using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Trainers have:
//Name
//Number of badges
//A collection of pokemon
namespace PokemonTrainer
{
    public class Trainer
    {
        private List<Pokemon> collection;
        private int badges = 0;
        public Trainer(string name)
        {
            this.Name= name;
            this.collection = new();
        }
        public string Name { get; set; }
        public int Badges 
        {
            get 
            { 
                return badges;
            }
            set 
            { 
                this.badges = value;
            } 
        }
        public int NumberOfPokemons 
        {
            get
            {
                return this.collection.Count;
            }
        }
        public void AddPokemon(Pokemon pokemon)
        {
            this.collection.Add(pokemon);
        }
        public void Challenge(string element)
        {
            List<Pokemon> matchingPokemons = this.collection.Where(p => p.Element == element).ToList();
            if (matchingPokemons.Count != 0)
            {
                this.Badges += matchingPokemons.Count;
            }
            else
            {
                for (int i = 0; i < this.collection.Count; i++)
                {
                    this.collection[i].Health -= 10;
                    if (this.collection[i].Health <= 0)
                    {
                        this.collection.Remove(collection[i]);
                    }
                }
            }
        }
    }
}
