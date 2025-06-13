using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicTrialGame.Interfaces;

namespace MagicTrialGame.Models
{
    public class Riddle : IRiddle
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public Riddle(string question, string answer)
        {
            Question = question;
            CorrectAnswer = answer;
        }
        public bool CheckAnswer(string answer)
        {
            return string.Equals(answer, CorrectAnswer, StringComparison.OrdinalIgnoreCase);
        }
    }
}