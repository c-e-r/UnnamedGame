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
    [Serializable]
    [XmlInclude(typeof(DamageEffect))]
    [XmlInclude(typeof(TestEffect))]
    public abstract class Effect
    {

        enum Desc { Activate, Resist }


        public String Id { get; set; }

        [XmlAttribute]
        public String Name { get; set; }


        [XmlAttribute]
        protected int acc;

        [XmlAttribute]
        protected int resistType;

        [XmlAttribute]
        protected int result;

        [XmlAttribute]
        protected int duration;
        [XmlAttribute]
        protected int increment;

        [XmlArray(IsNullable = true)]
        public List<Effect> Children { get; set; }

        protected Entity creator;

        public Effect()
        {
            Children = new List<Effect>();
        }

        public static Effect EffectFromXml(String filename, Entity creator)
        {

            Effect test;
            XmlDocument doc = new XmlDocument();
            doc.Load("data/" + filename);
            String type = doc.FirstChild.Name;

            XmlSerializer mySerializer = new XmlSerializer(Type.GetType("UnnamedGame." + type, true));

            FileStream myFileStream = new FileStream("data/" +filename, FileMode.Open);

            test = (Effect)mySerializer.Deserialize(myFileStream);

            Debug.WriteLine(test.Name);

            return null;
        }

        public void Activate(object sender, EntityEventArgs e)
        {
            Debug.WriteLine(e.Rsn);
            Apply((Entity) sender);
        }

        public void Apply(Entity entity)
        {
            Trigger(entity);
            foreach (Effect effect in Children)
            {

                effect.Apply(entity);
            }
        }

        public abstract void Trigger(Entity entity);

        public abstract void Update();

        public bool IsInstant()
        {
            return duration == 0;
        }
    }
}
