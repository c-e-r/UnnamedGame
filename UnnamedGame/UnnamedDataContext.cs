using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class UnnamedDataContext
    {

        public UnnamedDataContext() {


           PlayerOptions = new OptionsData();
        }

        public OptionsData PlayerOptions { get; set; }

    }

}
