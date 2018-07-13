using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class ArmourInfo
    {
        public Dictionary<Damage.DmgType, int> Reduction { get; set; }

        public Dictionary<Damage.DmgType, int> Resistance { get; set; }


    }
}
