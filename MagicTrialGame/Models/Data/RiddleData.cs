namespace MagicTrialGame.Models
{
    public record RiddleData(
        int Id,
        int RoomNumber,
        string RoomName,
        string Question,
        List<string> Options,
        string Answer,
        string Artifact,
        int MagicPower,
        string Hint
    );
}