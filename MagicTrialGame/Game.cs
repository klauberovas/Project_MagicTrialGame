namespace MagicTrialGame.Models
{

    public class Game
    {
        private readonly GameEngine gameEngine;

        public Game()
        {
            gameEngine = new GameEngine();
        }

        public void Run()
        {
            gameEngine.Run();
        }
    }
}