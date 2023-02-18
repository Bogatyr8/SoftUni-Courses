using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApocalypsePreparation;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> producedKits = new Dictionary<string, int>();

        Dictionary<string, int> medicalItems = new Dictionary<string, int>()
        {
            { "Patch" , 30 },
            { "Bandage", 40 },
            { "MedKit", 100}
        };

        Queue<int> textiles = new Queue<int>(Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse));

        Stack<int> medicaments = new Stack<int>(Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse));

        while (textiles.Count > 0 && medicaments.Count > 0)
        {
            int textile = textiles.Peek();
            int medicament = medicaments.Peek();
            int newMedicalItem = textile + medicament;
            if (medicalItems.ContainsValue(newMedicalItem))
            {
                foreach (KeyValuePair<string, int> medicalItem in medicalItems)
                {
                    if (medicalItem.Value == newMedicalItem)
                    {
                        if (!producedKits.ContainsKey(medicalItem.Key))
                        {
                            producedKits.Add(medicalItem.Key, 0);
                        }
                        textiles.Dequeue();
                        medicaments.Pop();
                        producedKits[medicalItem.Key]++;
                        break;
                    }
                }
            }
            else
            {
//remove both values, and add the remaining resources(of the sum) to the next value in the
//medicament collection (Take the element from the collection, add the remaining sum to it,
//and put the element back to its place).
                if (newMedicalItem > medicalItems["MedKit"])
                {
                    if (!producedKits.ContainsKey("MedKit"))
                    {
                        producedKits.Add("MedKit", 0);
                    }
                    producedKits["MedKit"]++;
                    textiles.Dequeue();
                    medicaments.Pop();
                    newMedicalItem -= 100;
                    medicaments.Push(medicaments.Pop() + newMedicalItem);
                }
                else if (newMedicalItem < medicalItems["MedKit"])
                {
                    medicament += 10;
                    textiles.Dequeue();
                    medicaments.Pop();
                    medicaments.Push(medicament);
                }
//If you can’t create anything, remove the textile value, add 10 to the medicament value and
//return the medicament back to its place, into its collection.
            }

        }

        if (textiles.Count == 0 && medicaments.Count == 0)
        {
            Console.WriteLine("Textiles and medicaments are both empty.");
        }
        else if (medicaments.Count == 0)
        {
            Console.WriteLine("Medicaments are empty.");
        }
        else if (textiles.Count == 0)
        {
            Console.WriteLine("Textiles are empty.");
        }


        Dictionary<string, int> sortedKits = producedKits
            .OrderByDescending(k => k.Value)
            .ThenBy(k => k.Key)
            .ToDictionary(x => x.Key, y => y.Value);

        foreach (var item in sortedKits)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
        if (medicaments.Count != 0)
        {
            Console.WriteLine($"Medicaments left: {String.Join(", ", medicaments)}");
        }

        if (textiles.Count != 0)
        {
            Console.WriteLine($"Textiles left: {String.Join(", ", textiles)}");
        }
    }
}