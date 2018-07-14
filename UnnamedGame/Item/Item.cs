using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UnnamedGame
{
    public class Item
    {

        public enum ItemSlot { LHand, RHand, LHeld, RHeld, Feet, Head, Body, Neck }

        [XmlArray]
        public List<ItemSlot> ValidSlots { get; set; }
        [XmlArray]
        public List<Effect> EquipEffects { get; set; }
        [XmlArray]
        public List<Ability> EquipAbilities { get; set; }
        
        [XmlElement]
        public ArmourInfo Armour { get; set; }
        [XmlElement]
        public WeaponInfo Weapon { get; set; }

        [XmlElement]
        public Ability UseAbiltiy { get; set; }

        [XmlAttribute]
        public string Id { get; set; }

        [XmlAttribute("weight")]
        public double Weight { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("uses")]
        public int Uses { get; set; }
        [XmlAttribute("maxUses")]
        public int MaxUses { get; set; }


        public Item()
        {

        }

        public static Item ItemFromXml(String filename)
        {

            Item test;
            XmlSerializer mySerializer = new XmlSerializer(typeof(Item));

            FileStream myFileStream = new FileStream("data/" + filename, FileMode.Open);

            test = (Item)mySerializer.Deserialize(myFileStream);
            myFileStream.Close();

            
            return test;
        }
    }
}
