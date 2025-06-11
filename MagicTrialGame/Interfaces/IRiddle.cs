using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Interfaces
{
    public interface IRiddle
    {
        string Question { get; }
        string CorrectAnswer { get; }
        bool CheckAnswer(string answer);
    }
}