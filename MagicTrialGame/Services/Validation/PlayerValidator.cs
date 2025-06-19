using MagicTrialGame.UI;

namespace MagicTrialGame.Models
{
    public class PlayerValidator
    {
        public Player CreateValidatePlayer()
        {
            while (true)
            {
                string input = Console.ReadLine()?.Trim();

                var validationResult = ValidateName(input);
                if (validationResult.IsValid)
                {
                    return new Player(input);
                }

                GameUI.DisplayValidationError(validationResult.ErrorMessage);
            }
        }
        private ValidationResult ValidateName(string name)
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