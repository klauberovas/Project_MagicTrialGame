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
        public Artifact RoomArtifact { get; set; }

        public Room(RiddleData riddleData)
        {
            Number = riddleData.RoomNumber;
            Name = riddleData.RoomName;
            Riddle = new Riddle(riddleData.Question, riddleData.Answer, riddleData.Hint, riddleData.Options);
            RoomArtifact = new Artifact(riddleData.Artifact, riddleData.Spell);
        }
        // public RoomResult ProcessRoom(Player player)
        // {
        //     // Logika pro zpracování místnosti
        //     // 3 pokusy, vyhodnocení odpovědi
        // }

    }
}