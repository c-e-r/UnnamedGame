using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class TestEffect : Effect
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
