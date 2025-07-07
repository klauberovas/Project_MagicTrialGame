namespace MagicTrialGame.Models
{
    public class Riddle
    {
        public string Question { get; protected set; }
        public string CorrectAnswer { get; protected set; }
        public string Hint { get; protected set; }
        public List<string> Options { get; protected set; }

        public Riddle(string question, string correctAnswer, string hint = null, List<string> options = null)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            Hint = hint ?? "Žádná nápověda není k dispozici";
            Options = options ?? new List<string>();
        }

        public bool CheckAnswer(string answer)
        {
            return string.Equals(answer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }
}
