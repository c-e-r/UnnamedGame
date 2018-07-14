﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{

    public class DamageEffect : Effect
    {


        public override void Trigger(Entity entity)
        {
            entity.TakeDamage(new Damage(1, Damage.DmgType.Untyped));
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
