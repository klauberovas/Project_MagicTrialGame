namespace MagicTrialGame.Models
{
    public class RoomFactory
    {
        public List<Room> CreateRooms(List<RiddleData> riddleDataList)
        {
            var rooms = new List<Room>();

            foreach (var riddleData in riddleDataList)
            {
                Room room = new Room(riddleData);
                rooms.Add(room);
            }

            rooms.Sort((x, y) => x.Number.CompareTo(y.Number));
            return rooms;
        }
    }
}