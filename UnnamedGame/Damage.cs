using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class Damage
    {

        public enum DmgType { Untyped, Pierce, Slash, Bludge, Fire, Cold, Elec, Sacred, Profane, Poison, Bleed }

        public int Value { get; set; }
        public DmgType Type { get; set; }

        public Damage(int value , DmgType type)
        {
            Value = value;
            Type = type;
        }

    }
}
