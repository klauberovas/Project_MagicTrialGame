using MagicTrialGame.UI;

namespace MagicTrialGame.Models.Rooms
{
    public class RoomManager
    {
        private readonly RoomProcessor _processor;

        public RoomManager()
        {
            _processor = new RoomProcessor();
        }

        public void ProcessRoom(RoomData room, Player player)
        {
            DisplayRoomInfo(room);

            bool isCorrectAnswer = _processor.ProcessRoomRiddle(room, player);

            if (isCorrectAnswer)
            {
                _processor.HandleCorrectAnswer(player, room);
            }
            else
            {
                _processor.HandleIncorrectAnswer(player);
            }

            GameUI.ContinuePrompt();
        }

        private void DisplayRoomInfo(RoomData room)
        {
            GameUI.DisplayRoom(room);
            GameUI.DisplayRiddle(room.Riddle.Question);
            GameUI.DisplayHint(room.Riddle.Hint);
            GameUI.DisplayOptions(room.Riddle.Options);
        }
    }
}