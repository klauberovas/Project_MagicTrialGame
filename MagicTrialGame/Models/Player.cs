using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Artifact> Artifacts { get; set; }
        public bool HasAnyArtifact => Artifacts.Count > 0;
        public bool HasAllArtifacts => Artifacts.Count == 5;

        public Player(string name)
        {
            Name = name;
            Artifacts = new List<Artifact>();
        }

    }
}