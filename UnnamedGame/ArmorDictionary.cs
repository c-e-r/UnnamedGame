using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace UnnamedGame
{
    public class ArmorDictionary : Dictionary<Enum, int>, IXmlSerializable
    {
        public XmlSchema GetSchema()
        {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader)
        {
            

            while (reader.MoveToNextAttribute())
            {
                
                Debug.WriteLine(" {0}={1}", reader.Name, reader.Value);
                this.Add((Damage.DmgType)Enum.Parse(typeof(Damage.DmgType), reader.Name), Int32.Parse(reader.Value));

            }

            /*
            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            bool wasEmpty = reader.IsEmptyElement;

            reader.Read();

            if (wasEmpty)
            {
                return;
            }

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement("Item");

                reader.ReadStartElement("Key");
                TKey key = (TKey)keySerializer.Deserialize(reader);
                reader.ReadEndElement();

                reader.ReadStartElement("Value");
                TValue value = (TValue)valueSerializer.Deserialize(reader);
                reader.ReadEndElement();

                this.Add(key, value);

                reader.ReadEndElement();
                reader.MoveToContent();
            }

            reader.ReadEndElement();
            */
        }

        public void WriteXml(XmlWriter writer)
        {
            //XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            //XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            foreach (Enum key in this.Keys)
            {
                //TValue value = this[key];

                //keySerializer.Serialize(writer, key);

                //valueSerializer.Serialize(writer, value);

                writer.WriteAttributeString(key.ToString(), this[key].ToString());
                /*
                writer.WriteStartElement("Item");

                writer.WriteStartElement("Key");
                keySerializer.Serialize(writer, key);
                writer.WriteEndElement();

                writer.WriteStartElement("Value");
                TValue value = this[key];
                valueSerializer.Serialize(writer, value);
                writer.WriteEndElement();

                writer.WriteEndElement();
                */
            }
        }
    }
}
