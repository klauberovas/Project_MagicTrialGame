namespace MagicTrialGame.Models
{
    public class GameInitializer
    {
        private readonly RiddleLoader riddleLoader = new RiddleLoader();
        private readonly RoomFactory roomFactory = new RoomFactory();

        public GameData Initialize()
        {
            var riddles = riddleLoader.LoadRiddles();
            var rooms = roomFactory.CreateRooms(riddles);
            var enemy = new Enemy("Stín", 15);

            return new GameData(enemy, rooms);
        }
    }
}