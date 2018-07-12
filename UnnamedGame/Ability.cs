using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class Ability
    {

        private List<Effect> effects;

        private String id;  
        private bool offensive;
        private int cost;

        public String name;
        public String description;

        public Ability(String name)
        {
            this.name = name;
            description = "Test ability";
        }


        

    }
}
