using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
		private string name;
		private decimal money;
		private List<Product> bagOfProducts;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bagOfProducts = new();
        }

        public string Name
		{
            get => name;
			set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
			}
		}

		public decimal Money
		{
            get => money;
			set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value; 
			}
		}

		public IReadOnlyList<Product> BagOfProducts
		{
            get => bagOfProducts.AsReadOnly();
		}

        public override string ToString() 
        {
            if (bagOfProducts.Count != 0)
            {
                return $"{Name} - {string.Join(", ", bagOfProducts)}"; ;
            }
            else
            {
                return $"{Name} - Nothing bought";
            }
        } 

        public void AddToList(Product product)
        {
            bagOfProducts.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }


    }
}
