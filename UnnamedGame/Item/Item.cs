using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnamedGame
{
    public class Item
    {

        public enum ItemSlot {LHand, RHand, LHeld, RHeld, Feet, Head, Body, Neck }

        public List<ItemSlot> ValidSlots { get; private set; }

        public List<Effect> EquipEffects { get; set; }

        public List<Ability> EquipAbilities { get; set; }

        public WeaponInfo Weapon { get; set; }

        public ArmourInfo Armour { get; set; }

        public Ability UseAbiltiy { get; private set; }

        public string Id { get; private set; }
        public double Weight { get; private set; }

        public int Uses { get; private set; }
        public int MaxUses { get; private set; }


        public Item()
        {

        }
    }
}
