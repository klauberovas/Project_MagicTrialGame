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