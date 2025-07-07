namespace MagicTrialGame.Models
{
    public class Player(string name) : Entity(name, 0)
    {
        private string _name;
        public const int MAX_ARTIFACT_COUNT = 5;
        public override string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Jméno nemůže být prázdné.");

                _name = char.ToUpper(value[0]) + value.Substring(1).ToLower();
            }
        }
        public List<Artifact> Artifacts { get; set; } = new List<Artifact>();
        public bool HasAnyArtifact => Artifacts != null && Artifacts.Count > 0;
        public bool HasAllArtifacts => Artifacts != null && Artifacts.Count == MAX_ARTIFACT_COUNT;
    }
}