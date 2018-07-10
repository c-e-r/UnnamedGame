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
        public static ObservableCollection<Option> Options(Action<ObservableCollection<Option>> set)
        {
            return new ObservableCollection<Option>
            {
                new Option("Back", () => set(MainMenu.Options(set))),
                new Option("test2", () => System.Diagnostics.Trace.WriteLine("test2 pressed"))

            };
        }
    }
}
