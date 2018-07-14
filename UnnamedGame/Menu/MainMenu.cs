using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;
using UnnamedGame.Menu;

namespace UnnamedGame
{
    public class MainMenu : UnnamedMenu
    {

        public MainMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu)
            : base(ctx, prevMenu)
        {
            ThisMenu = () => new MainMenu(ctx, prevMenu);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("Start Test Event", () =>Next(new EventMenu(Ctx, ThisMenu, "test.xml"))));
            Options.Add(new Option("submenu", () => Next(new Submenu(Ctx, ThisMenu))));
            Options.Add(new Option("Pass Time", () => Ctx.Time.Pass(3)));
            Options.Add(new Option("Start Test Combat", () => new Combat(Ctx, Ctx.Player, new Entity(Ctx))));
            Options.Add(new Option("Console Test", () => ctx.Cnsl.Append("test") ));



        }

    }
}
