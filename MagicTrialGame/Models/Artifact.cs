using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Artifact
    {
        public string Name { get; set; }
        public Artifact(string name)
        {
            Name = name;
        }
    }
}