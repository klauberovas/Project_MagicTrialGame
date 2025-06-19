namespace MagicTrialGame.Models.Rooms
{
    public class RoomData
    {

        public int Number { get; set; }
        public string Name { get; set; }
        public Riddle Riddle { get; set; }
        public Artifact RoomArtifact { get; set; }
        public RoomData(RiddleData riddleData)
        {
            Number = riddleData.RoomNumber;
            Name = riddleData.RoomName;
            Riddle = new Riddle(riddleData.Question, riddleData.Answer, riddleData.Hint, riddleData.Options);
            RoomArtifact = new Artifact(riddleData.Artifact, riddleData.MagicPower);
        }
    }
}