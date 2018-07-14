using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{
    [Serializable]
    public class Ability
    {
        [XmlArrayItem]
        public List<Effect> Effects { get; set; }

        private String id;
        [XmlAttribute]
        public bool Offensive { get; set; }
        [XmlAttribute]
        public int Cost { get; set; }

        [XmlAttribute]
        public String Name { get; set; }
        [XmlAttribute]
        public String Desc { get; set; }

        public Ability(String name)
        {
            Name = name;
            Desc = "Test ability";
            Effects = new List<Effect>();
            Effects.Add(new DamageEffect());
            

        }

        public Ability()
        {

        }




    }
}
