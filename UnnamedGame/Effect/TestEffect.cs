using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{
    [Serializable]
 
    public class TestEffect : Effect
    {
        public override void Trigger(Entity entity)
        {
            Debug.WriteLine("TestEffect triggered");
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
