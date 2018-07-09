using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UnnamedGame
{
    class OptionButton : Button
    {

        public OptionButton()
        {
            this.Click += DoOptionAction;
        }

        private void DoOptionAction(object sender, EventArgs e)
        {
            var button = sender as Button;
            var option = button.DataContext as Option;
            option.Act();
        }
    }

    
}
