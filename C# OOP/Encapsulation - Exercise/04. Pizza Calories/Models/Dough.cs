using System;
using System.Collections.Generic;

namespace PizzaCalories.Models;

public class Dough
{
    private const double BaseModifier = 2;
    private readonly Dictionary<string, double> doughTypeCalories;
    private readonly Dictionary<string, double> bakingTechniqueCalories;
    private string doughType;
    private string bakingTechnique;
    private double weight;
    public Dough(string doughType, string bakingTech, double weight)
    {
        doughTypeCalories =
        new() { { "white", 1.5 }, { "wholegrain", 1.0 } };

        bakingTechniqueCalories =
        new() { { "crispy", 0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 } };

        DoughType = doughType;
        BakingTechnique = bakingTech;
        Weight = weight;
    }

    public double Weight
    {
        get => weight;
        private set
        {
            if (value < 0 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            weight = value;
        }
    }

    public string DoughType
    {
        get => doughType;
        private set
        {
            if (!doughTypeCalories.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            doughType = value.ToLower();
        }
    }

    public string BakingTechnique
    {
        get => bakingTechnique;
        private set
        {
            if (!bakingTechniqueCalories.ContainsKey(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            bakingTechnique = value.ToLower();
        }
    }

    public double Calories
    {
        get
        {
            double doughTypeModifier = doughTypeCalories[DoughType];
            double bakingTypeModifier = bakingTechniqueCalories[bakingTechnique];

            return BaseModifier * weight * doughTypeModifier * bakingTypeModifier;

        }
    }


}
