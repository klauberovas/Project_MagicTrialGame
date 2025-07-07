using MagicTrialGame.UI;

namespace MagicTrialGame.Models
{
    public class PlayerValidator
    {
        public ValidationResult ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new ValidationResult(false, "Jméno nemůže být prázdné.");
            }
            if (!name.All(char.IsLetter))
            {
                return new ValidationResult(false, "Jméno může obsahovat pouze písmena.");
            }
            return new ValidationResult(true, "");
        }
    }
}