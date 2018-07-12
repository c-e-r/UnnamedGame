using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace UnnamedGame
{


    
    public class Console : TextBlock
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
