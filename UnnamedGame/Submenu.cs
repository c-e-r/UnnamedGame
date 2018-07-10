using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class Submenu
    {
        public static ObservableCollection<Option> Options(UnnamedDataContext ctx)
        {
            return new ObservableCollection<Option>
            {
                new Option("Back", () => ctx.PlayerOptions.OptionBack())

            };
        }
    }
}
