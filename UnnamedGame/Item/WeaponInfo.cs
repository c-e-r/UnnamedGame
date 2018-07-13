using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{
    [Serializable]
    public class WeaponInfo
    {
        [XmlAttribute]
        public int HitChance { get; set; }
        [XmlAttribute]
        public int Damage { get; set; }
        [XmlAttribute]
        public int CritChance { get; set; }
        [XmlAttribute]
        public double CritMult { get; set; }


    }
}
