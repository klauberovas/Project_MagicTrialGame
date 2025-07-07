using MagicTrialGame.UI;

namespace MagicTrialGame.Models.Rooms
{
    public class RoomProcessor
    {
        private const int MaxAttempts = 3;

        public bool ProcessRoomRiddle(RoomData room, Player player)
        {
            int attemps = 0;
            bool isCorrectAnswer = false;

            while (attemps < MaxAttempts && !isCorrectAnswer)
            {
                var userInput = GameUI.GetUserInput();

                if (userInput != null)
                {
                    isCorrectAnswer = ProcessAnswer(room.Riddle, userInput);
                }
                else
                {
                    GameUI.DisplayMessage("⚠️  Neplatná odpověď. Zadej znovu.", ConsoleColor.Cyan);
                }

                if (!isCorrectAnswer)
                {
                    attemps++;
                }
            }

            return isCorrectAnswer;
        }

        private bool ProcessAnswer(Riddle riddle, string answer)
        {
            if (riddle.CheckAnswer(answer))
            {
                GameUI.DisplayMessage("✅ Výborně!!! Správná odpověď.", ConsoleColor.Green);
                return true;
            }
            else
            {
                GameUI.DisplayMessage("❌ Nesprávná odpověď.", ConsoleColor.Red);
                return false;
            }
        }


        public void HandleCorrectAnswer(Player player, RoomData room)
        {
            player.Artifacts.Add(room.RoomArtifact);
            player.AbilityPower += room.RoomArtifact.MagicPower;
            GameUI.DisplayAward(room.RoomArtifact.Name, room.RoomArtifact.MagicPower, player.Name, player.AbilityPower);
        }

        public void HandleIncorrectAnswer(Player player)
        {
            GameUI.DisplayMessage($"🚫 Vyčerpali jste všechny pokusy {MaxAttempts} pokusy.", ConsoleColor.DarkRed);
            GameUI.DisplayNoAward(player.AbilityPower);
        }


    }
}