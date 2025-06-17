namespace MagicTrialGame.Models
{
    public abstract class BaseRiddle
    {
        public string Question { get; protected set; }
        public string CorrectAnswer { get; protected set; }
        public virtual string Hint { get; protected set; }
        public virtual List<string> Options { get; protected set; }
        protected BaseRiddle(string question, string correctAnswer, string hint = null, List<string> options = null)
        {
            Question = question;
            CorrectAnswer = correctAnswer;
            Hint = hint ?? "Žádná nápověda není k dispozici";
            Options = options ?? new List<string>();
        }

        public virtual bool CheckAnswer(string answer)
        {
            return answer.Equals(CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }
}