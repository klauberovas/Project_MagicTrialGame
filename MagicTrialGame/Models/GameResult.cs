using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public enum GameResult
    {
        Defeat, // 0 kouzel - prohra
        Victory, // 1-4 kouzla - výhra
        AbsoluteVictory // 5 kouzel - absolutní výhra
    }
}