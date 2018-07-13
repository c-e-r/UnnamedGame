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
        private bool Finished;
        private Entity Player;
        private Entity Enemy;
        private UnnamedDataContext Ctx;
        private UnnamedMenu PrevMenu;

        public Combat(UnnamedDataContext ctx, Entity player, Entity enemy)
        {

            Player = player;
            Enemy = enemy;
            Ctx = ctx;

            PrevMenu = Ctx.PlayerOptions.Menu;


            StartCombat();
        }

        private void StartCombat()
        {
            Debug.WriteLine("Combat Started");


            HandleTurn();
           
            
            
        }

        private void GetPlayerAction()
        {
            Player.SelectAction(UseAbilities);
        }

        private void HandleTurn()
        {
            Debug.WriteLine("New turn");

            //enemy.RandomAction();
            Player.SelectAction(UseAbilities);
        }

        private void UseAbilities(Ability playerAbility)
        {
            Debug.WriteLine("Player Ability '" + playerAbility.name + "' Recieved");
            Debug.WriteLine(Player.GetStatus());
            Player.RecieveAbility(new Ability("test"));
            Debug.WriteLine("Enemy Action");
            Debug.WriteLine(Player.GetStatus());


            if (!Finished)
            {
                HandleTurn();
            }
        }

    }
}
