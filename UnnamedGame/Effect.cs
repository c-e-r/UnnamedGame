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
            children = new List<Effect>();
        }


        public void Activate(object sender, EntityEventArgs e)
        {
            Apply((Entity) sender);
        }

        public void Apply(Entity entity)
        {
            Trigger(entity);
            foreach (Effect effect in children)
            {
                effect.Apply(entity);
            }
        }

        public abstract void Trigger(Entity entity);

        public abstract void Update();

    }
}
