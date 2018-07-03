using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UnnamedGame
{


    
    class Console : TextBlock
    {


        public Console()
        {

        }


        public void Append(String str)
        {
            this.Inlines.Add(str);
        }
    }

    
}
