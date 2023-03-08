using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony.Models.Interfaces;

public interface IPhoning
{

    abstract string Calling(string number);
}
