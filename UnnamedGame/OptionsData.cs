using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class OptionsData
    {

        public OptionsData()
        {
            Options = new ObservableCollection<Option>
            {
                new Option("test", () => System.Diagnostics.Trace.WriteLine("Test pressed")),
                new Option("test2", () => System.Diagnostics.Trace.WriteLine("test2 pressed")),
                new Option("test3", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test4444444444444444444444444444444444444444444444444444444444444444444444444", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test5", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test6", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test7", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test8", () => System.Diagnostics.Trace.WriteLine("test3 pressed")),
                new Option("test9", () => System.Diagnostics.Trace.WriteLine("test3 pressed"))

            };
        }
        public ObservableCollection<Option> Options { get; private set; }
    }


}
