using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace UnnamedGame
{
    class MainMenu : UnnamedMenu
    {
        public MainMenu(UnnamedDataContext ctx, Func<UnnamedMenu> back)
        {
            Options = new ObservableCollection<Option>();
            Options.Add(new Option("text", () => Debug.WriteLine(ctx.PlayerOptions.Menu)));
            Options.Add(new Option("submenu", () => ctx.PlayerOptions.Menu = new Submenu(ctx, () => new MainMenu(ctx, back))));

        }

    }
}
