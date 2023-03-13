using System.Collections.Generic;

namespace MilitaryElite;

public class LieutenantGeneral : Private
{
    public LieutenantGeneral(List<Private> privates)
    {
        Privates = privates;
    }

    public List<Private> Privates { get; private set; }
}
