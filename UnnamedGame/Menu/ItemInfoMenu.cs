using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame.Menu
{
    class ItemInfoMenu : UnnamedMenu
    {
        public ItemInfoMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu, Item item, Action<Ability> Select)
            : base(ctx, prevMenu)
        {
            ThisMenu = () => new ItemInfoMenu(ctx, prevMenu, item, Select);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("Back", () => Next(PrevMenu())));
            Options.Add(new Option("Use", () => Select(item.UseAbiltiy)));


        }

    }


}
