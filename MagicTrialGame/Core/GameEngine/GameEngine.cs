
namespace MagicTrialGame.Models
{
    public class GameEngine
    {
        private readonly GameInitializer initializer;
        private readonly GameFlow gameFlow;

        public GameEngine()
        {
            initializer = new GameInitializer();
            gameFlow = new GameFlow();
        }

        public void Run()
        {
            GameData gameData = initializer.Initialize();
            gameFlow.Execute(gameData);
        }
    }
}