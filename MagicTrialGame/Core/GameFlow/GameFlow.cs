using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicTrialGame.UI;

namespace MagicTrialGame.Models
{
    public class GameFlow
    {
        private readonly PlayerValidator playerValidator;
        public GameFlow()
        {
            playerValidator = new PlayerValidator();
        }
        public void Execute(GameData gameData)
        {
            GameUI.PlayerWelcome();

            InitializePlayer(gameData);

            GameUI.DisplayStory(gameData.Player.Name);

            ProcessRooms(gameData);

            ExecuteFinalBattle(gameData);
        }
        private void InitializePlayer(GameData gameData)
        {
            var validatedPlayer = playerValidator.CreateValidatePlayer();

            gameData.UpdatePlayer(validatedPlayer);
        }

        private void ProcessRooms(GameData gameData)
        {
            gameData.Rooms.ForEach(r => r.ProcessRoom(gameData.Player));
        }
        private void ExecuteFinalBattle(GameData gameData)
        {
            GameUI.DisplayFightIntro(gameData.Player, gameData.Enemy);
            var battleEngine = new BattleEngine();
            var battleResult = battleEngine.Fight(gameData.Player, gameData.Enemy);
            GameUI.DisplayGameResult(battleResult);
        }
    }
}