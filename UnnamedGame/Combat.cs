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
        private Ability enemyAbility;

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
            Ctx.Cnsl.Append("Combat Started" + "\n");


            HandleTurn();
           
            
            
        }

        private void GetPlayerAction()
        {
            Player.SelectAction(UseAbilities);
        }

        private void HandleTurn()
        {
            Ctx.Cnsl.Append("New turn" + "\n");

            //enemy.RandomAction();
            enemyAbility = new Ability("Enemy Ability" + "\n");
            Player.SelectAction(UseAbilities);
        }

        private void UseAbilities(Ability playerAbility)
        {
            Ctx.Cnsl.Append("Player" + Player.GetStatus() + "\n");
            Ctx.Cnsl.Append("Enemy" + Enemy.GetStatus() + "\n");

            Ctx.Cnsl.Append("player used " + playerAbility.Name + "\n");
            Player.RecieveAbility(enemyAbility);
            Ctx.Cnsl.Append("Enemy used " + playerAbility.Name + "\n");
            Enemy.RecieveAbility(playerAbility);


            if (!Finished)
            {
                HandleTurn();
            }
        }

    }
}
