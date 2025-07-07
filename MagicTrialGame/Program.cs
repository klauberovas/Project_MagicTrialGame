using MagicTrialGame.Models;

namespace MagicTrialGame;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Game game = new Game();
        game.Run();
    }
}
