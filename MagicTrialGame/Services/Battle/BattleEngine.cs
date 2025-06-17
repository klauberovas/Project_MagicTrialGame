using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class BattleEngine
    {
        public GameResult Fight(Player player, Enemy enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                player.Attack(enemy);

                if (enemy.Health <= 0)
                    break;

                enemy.Attack(player);
            }

            return player.Health <= 0 ? GameResult.Defeat : GameResult.Victory;
        }
    }
}
