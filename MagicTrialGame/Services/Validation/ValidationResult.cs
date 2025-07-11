namespace MagicTrialGame.Models
{
    public class ValidationResult
    {
        public bool IsValid { get; }
        public string ErrorMessage { get; }

        public ValidationResult(bool isValid, string message)
        {
            IsValid = isValid;
            ErrorMessage = message;
        }
    }
}