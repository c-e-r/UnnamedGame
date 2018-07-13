using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UnnamedGame
{
    [Serializable]
    public class ArmourInfo : IXmlSerializable
    {
        [XmlElement]
        private List<EnumPair<Damage.DmgType, int>> Reduction { get; set; }
        [XmlElement]
        private List<EnumPair<Damage.DmgType, int>> Resistance { get; set; }

        public ArmourInfo()
        {
            Reduction = new List<EnumPair<Damage.DmgType, int>>();
            Resistance = new List<EnumPair<Damage.DmgType, int>>();

            Resistance.Add(new EnumPair<Damage.DmgType, int>());
            Resistance[0].Type = Damage.DmgType.Bleed;
            Resistance[0].Value = 3;

            Resistance.Add(new EnumPair<Damage.DmgType, int>());
            Resistance[1].Type = Damage.DmgType.Fire;
            Resistance[1].Value = 6;

            Reduction.Add(new EnumPair<Damage.DmgType, int>());
            Reduction[0].Type = Damage.DmgType.Untyped;
            Reduction[0].Value = 9;


        }

        public int GetResistance(Damage.DmgType type)
        {
            return Resistance.Where(p => p.Type == type).First().Value;
        }

        public int GetReduction(Damage.DmgType type)
        {
            return Reduction.Where(p => p.Type == type).First().Value;
        }

        public void SetReduction(Damage.DmgType type, int value)
        {
            Reduction.Where(p => p.Type == type).First().Value = value;
        }

        public void SetResistance(Damage.DmgType type, int value)
        {
            Reduction.Where(p => p.Type == type).First().Value = value;
        }

        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            reader.ReadStartElement();
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                EnumPair<Damage.DmgType, int> temp = new EnumPair<Damage.DmgType, int>();
                Debug.WriteLine(reader.Name);
                temp.Type = (Damage.DmgType)Enum.Parse(typeof(Damage.DmgType), reader.GetAttribute("Type"));
                temp.Value = Int32.Parse(reader.GetAttribute("Value"));
                switch (reader.Name)
                {
                    case "Resitance":
                        {
                            Resistance.Add(temp);
                            break;
                        }

                    case "Reduction":
                        {
                            Reduction.Add(temp);
                            break;
                        }

                    default:
                        {
                            break;
                        }

                }
                reader.Read();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            foreach (EnumPair<Damage.DmgType, int> pair in Resistance)
            {
                writer.WriteStartElement("Resistance");
                writer.WriteAttributeString("Type", pair.Type.ToString());
                writer.WriteAttributeString("Value", pair.Value.ToString());
                writer.WriteEndElement();

            }

            foreach (EnumPair<Damage.DmgType, int> pair in Reduction)
            {
                writer.WriteStartElement("Reduction");
                writer.WriteAttributeString("Type", pair.Type.ToString());
                writer.WriteAttributeString("Value", pair.Value.ToString());
                writer.WriteEndElement();

            }

        }
    }
}
