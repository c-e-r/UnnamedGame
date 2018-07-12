using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnnamedGame
{
    public class Entity
    {

        public enum Stat { VIT, STR, DEX, INT, SPI, LCK }
        public enum DmgType { Untyped, Pierce, Slash, Bludge, Fire, Cold, Elec, Sacred, Profane, Poison, Bleed }
        public enum SecStat { Health, Mana, Stamina, Hit, Dodge, Heal, Effect, Speed, Crit }


        private Dictionary<Stat, int> _stats;
        private Dictionary<DmgType, int> _resistance;
        private Dictionary<DmgType, int> _armor;
        private Dictionary<Stat, int> _mults;

        private List<Effect> Effects;

        private List<Ability> Abilities;

        private int _hp;
        private int _stamina;
        private int _mana;

        public event EventHandler<EntityEventArgs> EntityEvent;

        public Entity(WorldTime time)
        {
            time.PropertyChanged += Time_PropertyChanged;
            

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

       

        public void TestEvent()
        {
            OnEntityEvent(new EntityEventArgs(EntityEventArgs.Reason.Test));
        }



        public int getResist(DmgType type)
        {
            return _resistance[type];
        }

        public int getArmor(DmgType type)
        {
            return _armor[type];
        }

        public int getStat(Stat stat)
        {
            return _stats[stat];
        }

        public int getSecStat(int stat)
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
