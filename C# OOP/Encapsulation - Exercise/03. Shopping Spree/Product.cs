using System;

namespace ShoppingSpree;

public class Product
{
	private string name;
	private decimal price;
    public Product(string name, decimal price)
    {
		Name = name;
		Price = price;
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

	public decimal Price
	{
        get => price;
		set 
		{
			if (value < 0)
			{
				throw new ArgumentException("Money cannot be negative");
			}
			price = value; 
		}
	}

    public override string ToString() => Name;

}
