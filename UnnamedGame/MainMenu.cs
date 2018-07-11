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
        public MainMenu(UnnamedDataContext ctx, Func<UnnamedMenu> goBack)
            : base(ctx, goBack)
        {
            Return = () => new MainMenu(Ctx, GoBack);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("text", () => Debug.WriteLine(Ctx.PlayerOptions.Menu)));
            Options.Add(new Option("submenu", () => Next(new Submenu(Ctx, Return))));

        }

    }
}
