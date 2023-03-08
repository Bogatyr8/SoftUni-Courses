using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telephony.Models.Interfaces;

namespace Telephony.Models;

public class Smartphone : IPhoning, IBrowsingWWW
{

    public string Calling(string number)
    {
        if (!IsNumberValid(number))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Dialing... {number}";
    }
    public string Browse(string site)
    {
        if (!IsSiteValid(site))
        {
            throw new ArgumentException("Invalid URL!");
        }
        return $"Browsing: {site}!";
    }

    private bool IsNumberValid(string number)
    {
        return number.All(c => char.IsDigit(c));
    }
    private bool IsSiteValid(string site)
    {
        return site.All(c => !char.IsDigit(c));
    }

}
