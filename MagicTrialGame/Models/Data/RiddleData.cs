using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class RiddleData
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string RoomName { get; set; }
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public string Answer { get; set; }
        public string Artifact { get; set; }
        public int MagicPower { get; set; }
        public string Hint { get; set; }
    }
}