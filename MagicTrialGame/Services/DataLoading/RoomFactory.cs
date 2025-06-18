using MagicTrialGame.Models.Rooms;

namespace MagicTrialGame.Models
{
    public class RoomFactory
    {
        public List<RoomData> CreateRooms(List<RiddleData> riddleDataList)
        {
            var rooms = new List<RoomData>();

            foreach (var riddleData in riddleDataList)
            {
                RoomData room = new RoomData(riddleData);
                rooms.Add(room);
            }

            rooms.Sort((x, y) => x.Number.CompareTo(y.Number));
            return rooms;
        }
    }
}