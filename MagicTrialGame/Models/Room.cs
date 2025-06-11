using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicTrialGame.Interfaces;

namespace MagicTrialGame.Models
{
    public class Room
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IRiddle Riddle { get; set; }
        public Spell RewardSpell { get; set; }
        public Artifact RewardArtifact { get; set; }

        // public RoomResult ProcessRoom(Player player)
        // {
        //     // Logika pro zpracování místnosti
        //     // 3 pokusy, vyhodnocení odpovědi
        // }

    }
}