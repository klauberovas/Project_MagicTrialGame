using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Player
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Jméno nemůže být prázdné.");

                _name = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        public List<Artifact> Artifacts { get; set; }
        public int AbilityPower { get; set; } = 0;
        public bool HasAnyArtifact => Artifacts.Count > 0;
        public bool HasAllArtifacts => Artifacts.Count == 5;

        public Player(string name)
        {
            Name = name;
            Artifacts = new List<Artifact>();
        }

    }
}