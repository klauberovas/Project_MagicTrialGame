using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Artifact
    {
        public string Name { get; }
        public Spell Spell { get; }
        public Artifact(string name, string spellName)
        {
            Name = name;
            Spell = new Spell(spellName);
        }
    }
}