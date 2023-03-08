using System;
using System.Linq;
using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class StationaryPhone : IPhoning
{

    public string Calling(string number)
    {
        if (!IsNumberValid(number))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Calling... {number}";
    }

    private bool IsNumberValid(string number)
    {
        return number.All(c => char.IsDigit(c));
    }
}
