using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Riddle : BaseRiddle
    {
        public Riddle(string question, string answer, string hint, List<string> options) : base(question, answer, hint, options)
        {
        }
        public bool CheckAnswer(string answer)
        {
            return string.Equals(answer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }
}