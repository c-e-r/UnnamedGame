using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    abstract class Effect
    {
        protected String id;
        protected String name;

        enum Desc { Activate, Resist }

        protected int acc;
        protected int resistType;

        protected int result;

        protected int duration;
        protected int increment;

        protected List<Effect> children;


        public Effect()
        {

        }


        abstract public void Activate(object sender, EntityEventArgs e);


        abstract public void Update();

    }
}
