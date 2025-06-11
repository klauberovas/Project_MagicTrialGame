using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Artifact> Artifact { get; set; }
        public bool HasAnySpell => Spells.Count > 0;
        public bool HasAllSpells => Spells.Count == 5;
    }
}