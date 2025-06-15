using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicTrialGame.Interfaces;

namespace MagicTrialGame.Models
{
    public class Riddle : IRiddle
    {
        public string Question { get; }
        public string CorrectAnswer { get; }
        public string Hint { get; }
        public List<string> Options { get; }
        public Riddle(string question, string answer, string hint, List<string> options)
        {
            Question = question;
            CorrectAnswer = answer;
            Hint = hint;
            Options = options;
        }
        public bool CheckAnswer(string answer)
        {
            return string.Equals(answer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }
}