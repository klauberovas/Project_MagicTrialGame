using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class Enemy : Entity
    {
        public Enemy(string name, int abilityPower) : base(name, abilityPower)
        {
        }
    }
}