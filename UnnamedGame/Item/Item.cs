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
        [XmlIgnore]
        public List<ItemSlot> ValidSlots { get; set; }
        [XmlIgnore]
        public List<Effect> EquipEffects { get; set; }
        [XmlIgnore]
        public List<Ability> EquipAbilities { get; set; }

        public ArmourInfo Armour { get; set; }
        public WeaponInfo Weapon { get; set; }

        [XmlIgnore]
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

        public static Effect ItemFromXml(String filename)
        {
            Item stest = new Item();
            stest.Name = "test";
            stest.Uses = 4;
            stest.MaxUses = 5;
            stest.Weight = 3.2;
            stest.Armour = new ArmourInfo();
            stest.Weapon = new WeaponInfo();
            stest.Weapon.Damage = 3;
            stest.Weapon.CritChance = 2;
            stest.Weapon.HitChance = 10;
            stest.Weapon.CritMult = 1.1;

            Item test;
            XmlDocument doc = new XmlDocument();
            doc.Load("data/serialize.xml");
            String type = doc.FirstChild.Name;

            XmlSerializer mySerializer = new XmlSerializer(typeof(Item));

            FileStream myFileStream = new FileStream("data/serialize.xml", FileMode.Create);
            mySerializer.Serialize(myFileStream, stest);
            myFileStream.Close();
            myFileStream = new FileStream("data/serialize.xml", FileMode.Open);

            test = (Item)mySerializer.Deserialize(myFileStream);
            myFileStream.Close();

            Debug.WriteLine(test.Name);
            Debug.WriteLine(test.Uses);
            Debug.WriteLine(test.MaxUses);
            Debug.WriteLine(test.Weight);
            Debug.WriteLine(test.Weapon.Damage);
            Debug.WriteLine(test.Armour);
            Debug.WriteLine(test.Armour.GetResistance(Damage.DmgType.Fire));

            return null;
        }
    }
}
