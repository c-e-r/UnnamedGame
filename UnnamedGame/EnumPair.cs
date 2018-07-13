using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{
    public class EnumPair<TEnum, TValue>
    {
        [XmlAttribute]
        public TEnum Type {get;set;}
        [XmlAttribute]
        public TValue Value { get; set; }

        public EnumPair()
        {

        }
        

    }
}
