using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
//Create a program that keeps information about companies and their employees.
//You will be receiving a company name and an employee's id, until you receive the "End" command. Add each employee to the given
//company. Keep in mind that a company cannot have two employees with the same id.
//When you finish reading the data, print the company's name and each employee's id in the following format:
//{ companyName}
//-- { id1}
//-- { id2}
//-- { idN}
//Input / Constraints
//•	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
//•	The input always will be valid.
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string inputString;

            while ((inputString = Console.ReadLine()) != "End")
            {
                string[] input = inputString
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);
                string company = input[0];
                string id = input[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                }
                else if (!companies[company].Contains(id))
                {
                    companies[company].Add(id);
                }
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
