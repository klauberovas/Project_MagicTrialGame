namespace MagicTrialGame.Models
{
    public abstract class Entity
    {
        public virtual string Name { get; set; }
        public int AbilityPower { get; set; }
        public int Health { get; set; } = 100;
        public Entity(string name, int abilityPower)
        {
            Name = name;
            AbilityPower = abilityPower;
        }

        public void Attack(Entity entity)
        {
            entity.Health -= this.AbilityPower;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"⚔️ {Name} útočí na {entity.Name} magickou silou {AbilityPower}!");

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (entity.Health <= 0)
            {
                Console.WriteLine($"💀 {entity.Name} zemřel.");
            }
            else
            {
                Console.WriteLine($"💔 {entity.Name} má nyní {entity.Health} životů");
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}