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
            testString = "supertest";
            Options = new ObservableCollection<Option>
            {
                new Option(),
                new Option()
            };
            TestStrings = new ObservableCollection<String>
            {
                "test",
                "test2"
            };
        }
        public ObservableCollection<Option> Options { get; private set; }
        public String testString { get; set; }
        public ObservableCollection<String> TestStrings {get; set;}
    }


}
