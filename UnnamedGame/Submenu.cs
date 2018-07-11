using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    class Submenu : UnnamedMenu
    {
        public Submenu(UnnamedDataContext ctx, Func<UnnamedMenu> goBack)
            : base(ctx, goBack)
        {
            Return = () => new MainMenu(Ctx, GoBack);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("Back", () => Next(GoBack())));
            Options.Add(new Option("text", () => Debug.Write("asdas")));
            Options.Add(new Option("text", () => Debug.Write("asdas")));

        }

    }
}
