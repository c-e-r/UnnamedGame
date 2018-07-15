using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame.Menu
{
    class SelectAbilityMenu : UnnamedMenu
    {
        public SelectAbilityMenu(UnnamedDataContext ctx, Func<UnnamedMenu> prevMenu, Entity entity,  Action<Ability> Select)
            : base(ctx, prevMenu)
        {
            ThisMenu = () => new SelectAbilityMenu(ctx, prevMenu, entity, Select);

            Options = new ObservableCollection<Option>();
            Options.Add(new Option("Back", () => Next(PrevMenu())));

            foreach (Ability ability in entity.Abilities)
            {
                Options.Add(new Option(ability.Name, () => Next(new AbilityInfoMenu(Ctx, ThisMenu, ability, Select))));
            }

        }

    }
}
