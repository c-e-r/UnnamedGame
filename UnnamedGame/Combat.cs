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
        private bool Win;
        private Entity Player;
        private Entity Enemy;
        private UnnamedDataContext Ctx;
        private Ability enemyAbility;
        private Func<UnnamedMenu> WinFunc;
        private Func<UnnamedMenu> LossFunc;

        public Combat(UnnamedDataContext ctx, Func<UnnamedMenu> winFunc, Func<UnnamedMenu> lossFunc, Entity player, Entity enemy)
        {

            Player = player;
            Enemy = enemy;
            Ctx = ctx;


            WinFunc = winFunc;
            LossFunc = lossFunc;


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

            Ctx.Cnsl.Append("Player" + Player.GetStatus() + "\n");
            Ctx.Cnsl.Append("Enemy" + Enemy.GetStatus() + "\n");

            //enemy.RandomAction();
            enemyAbility = new Ability("Enemy Ability" + "\n");
            Player.SelectAction(UseAbilities);
        }

        private void UseAbilities(Ability playerAbility)
        {

            int pSpeed = Player.CheckSpeed();
            int eSpeed = Enemy.CheckSpeed();

            if (pSpeed >= eSpeed)
            {
                if (!Finished)
                {
                    Ctx.Cnsl.Append("player used " + playerAbility.Name + "\n");
                    Enemy.RecieveAbility(playerAbility);
                    CheckDead();
                }
                if (!Finished)
                {
                    Ctx.Cnsl.Append("Enemy used " + enemyAbility.Name + "\n");
                    Player.RecieveAbility(enemyAbility);
                    CheckDead();
                }
            }
            else
            {
                if (!Finished)
                {
                    Ctx.Cnsl.Append("Enemy used " + enemyAbility.Name + "\n");
                    Player.RecieveAbility(enemyAbility);
                    CheckDead();
                }
                if (!Finished)
                {
                    Ctx.Cnsl.Append("player used " + playerAbility.Name + "\n");
                    Enemy.RecieveAbility(playerAbility);
                    CheckDead();
                }
            }






            if (!Finished)
            {
                HandleTurn();
            }
            else
            {
                if (Win)
                {
                    Ctx.Cnsl.Append("PlayerWin");
                    Ctx.PlayerOptions.Menu = WinFunc();
                }
                else
                {
                    Ctx.Cnsl.Append("PlayerLoss");
                    Ctx.PlayerOptions.Menu = LossFunc();
                }
            }
        }

        private void CheckDead()
        {
            if (Player.IsDead())
            {
                Finished = true;
                Win = false;
            }
            if (Enemy.IsDead())
            {
                Finished = true;
                Win = true;
            }

        }
    }
}
