using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class Option
    {
        public Option()
        {
            this.Text = "test";
        }

        public Option(String text, Action act)
        {
            this.Text = text;
            this.Act = act;
        }

        public string Text { get; set; }
        public Action Act { get; private set; }
        
    }
}
