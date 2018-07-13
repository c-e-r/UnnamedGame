using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using UnnamedGame.Menu;

namespace UnnamedGame
{
    public class Entity
    {

        public enum Stat { VIT, STR, DEX, INT, SPI, LCK }
        public enum SecStat { Health, Mana, Stamina, Hit, Dodge, Heal, Effect, Speed, Crit }

        public Dictionary<Item.ItemSlot, Item> Equipment { get; set; }

        private Dictionary<Stat, int> _stats;
        private Dictionary<Damage.DmgType, int> _resistance;
        private Dictionary<Damage.DmgType, int> _reduction;
        private Dictionary<Stat, int> _mults;

        private List<Effect> Effects;

        public List<Ability> Abilities { get; set; }

        private int _hp;
        private int _sp;
        private int _mp;

        private UnnamedDataContext Ctx;

        public event EventHandler<EntityEventArgs> EntityEvent;

        public Entity(UnnamedDataContext ctx)
        {
            Ctx = ctx;
            Ctx.Time.PropertyChanged += Time_PropertyChanged;

            Abilities = new List<Ability>();


            EntityEvent += new TestEffect().Activate;


            TestEvent();



        }

        private void Time_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            OnEntityEvent(new EntityEventArgs(EntityEventArgs.Reason.Time));
        }


        protected virtual void OnEntityEvent(EntityEventArgs e)
        {
            EntityEvent?.Invoke(this, e);
        }

        public String GetStatus()
        {
            return "hp: " + _hp + " mp:" + _mp + " sp:" + _sp;
        }
       

        public void TestEvent()
        {
            OnEntityEvent(new EntityEventArgs(EntityEventArgs.Reason.Test));
        }

        public void SelectAction(Action<Ability> act)
        {
            Ctx.PlayerOptions.Menu = new SelectActionMenu(Ctx, null, this, act);
        }

        public void RecieveAbility(Ability ability)
        {
            foreach (Effect effect in ability.Effects)
            {
                RecieveEffect(effect);
            }
        }

        public void RecieveEffect(Effect effect)
        {
            if (effect.IsInstant())
            {
                effect.Apply(this);
            } else
            {
                Effects.Add(effect);
                EntityEvent += effect.Activate;
            }
        }

        public int TakeDamage(Damage dmg)
        {
            _hp -= dmg.Value;
            return dmg.Value;
        }


        public int GetStat(Stat stat)
        {
            return _stats[stat];
        }

        public int GetSecStat(int stat)
        {
            switch ((SecStat)stat)
            {
                case SecStat.Health:
                    {
                        return 0;
                    }
                case SecStat.Mana:
                    {
                        return 0;
                    }
                case SecStat.Stamina:
                    {
                        return 0;
                    }
                case SecStat.Hit:
                    {
                        return 0;
                    }
                case SecStat.Dodge:
                    {
                        return 0;
                    }
                case SecStat.Heal:
                    {
                        return 0;
                    }
                case SecStat.Effect:
                    {
                        return 0;
                    }
                case SecStat.Speed:
                    {
                        return 0;
                    }
                case SecStat.Crit:
                    {
                        return 0;
                    }
                default:
                    {
                        return 0;
                    }

            }
        }

    }
}
