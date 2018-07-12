using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class UnnamedDataContext
    {

        public UnnamedDataContext()
        {

            PlayerOptions = new OptionsData(this);
            Time = new WorldTime();
            Player = new Entity(this);

            Player.Abilities.Add(new Ability("test1"));
            Player.Abilities.Add(new Ability("test2"));

        }

        public OptionsData PlayerOptions { get; set; }
        public WorldTime Time { get; set; }
        public Entity Player { get; set; }
    }

}
