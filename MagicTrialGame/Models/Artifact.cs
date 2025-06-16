using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Artifact
    {
        public string Name { get; }
        public int MagicPower { get; }
        public Artifact(string name, int magicPower)
        {
            Name = name;
            MagicPower = magicPower;
        }
    }
}