using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame.Menu
{
    class AbilityInfoMenu : UnnamedMenu
    {
        public AbilityInfoMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu, Ability ability, Action<Ability> Select)
            : base(ctx, prevMenu)
        {
            ThisMenu = () => new AbilityInfoMenu(ctx, prevMenu, ability, Select);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("Back", () => Next(PrevMenu())));
            Options.Add(new Option("Use", () => Select(ability)));


        }

    }
    
}
