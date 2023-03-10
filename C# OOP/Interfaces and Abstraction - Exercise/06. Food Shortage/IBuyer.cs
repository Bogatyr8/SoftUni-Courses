using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    internal interface IBuyer
    {
        int Food { get; }
        public void BuyFood();
    }
}
