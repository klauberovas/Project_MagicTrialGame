using MagicTrialGame.Models.Rooms;

namespace MagicTrialGame.Models
{
    public class RoomFactory
    {
        public List<RoomData> CreateRooms(List<RiddleData> riddleDataList)
        {
            var rooms = riddleDataList.Select(riddleData => new RoomData(riddleData)).ToList();

            rooms.Sort((x, y) => x.Number.CompareTo(y.Number));
            return rooms;
        }
    }
}