using MagicTrialGame.Models.Rooms;

namespace MagicTrialGame.Models
{
    public class GameData
    {
        public Player Player { get; private set; }
        public Enemy Enemy { get; }
        public List<RoomData> Rooms { get; }
        public GameData(Enemy enemy, List<RoomData> rooms)
        {
            Enemy = enemy;
            Rooms = rooms;
        }

        public void UpdatePlayer(Player newPlayer)
        {
            Player = newPlayer ?? throw new ArgumentNullException(nameof(newPlayer));
        }
    }
}