using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame.Menu
{
    class SelectItemMenu : UnnamedMenu
    {
        public SelectItemMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu, Entity entity,  Action<Ability> Select)
            : base(ctx, prevMenu)
        {
            ThisMenu = () => new SelectItemMenu(ctx, prevMenu, entity, Select);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("Back", () => Next(PrevMenu())));

            foreach (Item item in entity.Items)
            {
                Options.Add(new Option(item.Name, () => Select(item.UseAbiltiy)));
            }

        }

    }
}
