using Microsoft.Win32;
using SoftUniKindergarten;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        public Kindergarten(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Registry = new();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int ChildrenCount { get => Registry.Count; }
        public List<Child> Registry { get; set; }
        public bool AddChild(Child child)
        {
            if (Capacity != 0)
            {
                Registry.Add(child);
                Capacity--;
                return true;
            }
            return false;
        }
        public bool RemoveChild(string childFullName)
        {
            string[] fullName = childFullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = fullName[0];
            string lastName = fullName[1];
            for (int i = 0; i < Registry.Count; i++)
            {
                if (Registry[i].FirstName == firstName && Registry[i].LastName == lastName)
                {
                    return Registry.Remove(Registry[i]);
                }
            }
            return false;
        }
        public Child GetChild(string childFullName)
        {
            string[] fullName = childFullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstName = fullName[0];
            string lastName = fullName[1];
            foreach (var kid in Registry)
            {
                if (kid.FirstName == firstName && kid.LastName == lastName)
                {
                    return kid;
                }
            }
            return null;
        }
        public string RegistryReport()
        {
            List<Child> children = Registry
                .OrderByDescending(c => c.Age)
                .ThenBy(c => c.LastName)
                .ThenBy(c => c.FirstName)
                .ToList();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");
            foreach (var child in children)
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString();
        }
    }
}
