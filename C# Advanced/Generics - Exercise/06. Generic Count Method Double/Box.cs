using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble;

public class Box<T> where T : IComparable<T>
{
    private List<T> list;

    public Box() 
    {
        list = new List<T>();
    }
    public void Add(T value)
    {
        list.Add(value);
    }
    public int CompareTo(T element)
    {
        int counter = 0;
        foreach (var item in list)
        {
            if (item.CompareTo(element) > 0)
            {
                counter++;
            }
        }
        return counter;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(); 
        foreach (T item in list)
        {
            sb.AppendLine($"{typeof(T)}: {item}");
        }
        return sb.ToString().TrimEnd();
    }
}
