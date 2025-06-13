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
        public IRiddle Riddle { get; set; }
        public string Hint { get; set; }
        public Spell RewardSpell { get; set; }
        public Artifact RewardArtifact { get; set; }

        public Room(RiddleData riddleData)
        {
            Number = riddleData.RoomNumber;
            Name = riddleData.RoomName;
            Riddle = new Riddle(riddleData.Question, riddleData.Answer);
            Hint = riddleData.Hint;
            RewardSpell = new Spell(riddleData.Spell);
            RewardArtifact = new Artifact(riddleData.Artifact);
        }
        // public RoomResult ProcessRoom(Player player)
        // {
        //     // Logika pro zpracování místnosti
        //     // 3 pokusy, vyhodnocení odpovědi
        // }

    }
}