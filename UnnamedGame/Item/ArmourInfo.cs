using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{
    [Serializable]
    public class ArmourInfo
    {
        [XmlElement]
        public ArmorDictionary Reduction { get; set; }
        [XmlElement]
        public ArmorDictionary Resistance { get; set; }

        public ArmourInfo()
        {
            Reduction = new ArmorDictionary();
            Resistance = new ArmorDictionary();

            Reduction.Add(Damage.DmgType.Bleed, 3);

        }


    }
}
