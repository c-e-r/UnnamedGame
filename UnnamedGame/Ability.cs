using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class Ability
    {

        public List<Effect> Effects { get; private set; }

        private String id;
        private bool offensive;
        private int cost;

        public String name;
        public String description;

        public Ability(String name)
        {
            this.name = name;
            description = "Test ability";
            Effects = new List<Effect>();
            Effects.Add(new DamageEffect());


        }

        public Ability()
        {

        }




    }
}
