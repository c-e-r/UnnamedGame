using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{
    public class WeaponInfo
    {
        [XmlAttribute("hit")]
        public int WepHitChance { get; set; }
        [XmlAttribute("damage")]
        public int WepDamage { get; set; }
        [XmlAttribute("crit")]
        public int WepCritChance { get; set; }
        [XmlAttribute("critMult")]
        public int WepCritMult { get; set; }


    }
}
