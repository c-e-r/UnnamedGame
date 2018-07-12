using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnnamedGame.Menu;

namespace UnnamedGame
{
    class Combat
    {
        private bool finished;
        private Entity player;
        private Entity enemy;
        private UnnamedDataContext Ctx;
        private UnnamedMenu PrevMenu;

        public Combat(UnnamedDataContext Ctx, Entity player, Entity enemy)
        {
            PrevMenu = Ctx.PlayerOptions.Menu;

            this.player = player;
            this.enemy = enemy;
            this.Ctx = Ctx;


            StartCombat();
        }

        private void StartCombat()
        {
            Debug.WriteLine("Combat Started");


            HandleTurn();
           
            
            
        }

        private void GetPlayerAction()
        {
            player.SelectAction(UseAbilities);
        }

        private void HandleTurn()
        {
            Debug.WriteLine("New turn");

            //enemy.RandomAction();
            player.SelectAction(UseAbilities);
        }

        private void UseAbilities(Ability playerAbility)
        {
            Debug.WriteLine("Player Ability '" + playerAbility.name + "' Recieved");

            Debug.WriteLine("Enemy Action");

            if (!finished)
            {
                HandleTurn();
            }
        }

    }
}
