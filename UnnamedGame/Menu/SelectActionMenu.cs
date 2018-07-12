using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame.Menu
{
    class SelectActionMenu : UnnamedMenu
    {
        public SelectActionMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu, Entity entity, Action<Ability> Select)
            : base(ctx, prevMenu)
        {
            ThisMenu = () => new SelectActionMenu(ctx, prevMenu, entity, Select);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("Attack", () => Select(new Ability("Attack"))));
            Options.Add(new Option("Abilities", () => Next(new SelectAbilityMenu(Ctx, ThisMenu, entity, Select))));
            Options.Add(new Option("Items", () => throw new NotImplementedException()));


        }

    }
}
