using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace UnnamedGame
{
    class MainMenu
    {

        public static ObservableCollection<Option> Options(Action<ObservableCollection<Option>> set)
        {
            return new ObservableCollection<Option>
            {
                new Option("Go to sub menu", () => set(Submenu.Options(set))),
                new Option("test2", () => System.Diagnostics.Trace.WriteLine("asd")),
                new Option("test3", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test5", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test6", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test7", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test8", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test9", () => System.Diagnostics.Trace.WriteLine("test3 pressed"))

            };
        }
    }
}
