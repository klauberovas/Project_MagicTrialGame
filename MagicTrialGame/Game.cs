using System.Text.Json;
using MagicTrialGame.UI;

namespace MagicTrialGame.Models
{
    public class Game
    {
        private Player player;
        private Enemy enemy;
        private readonly List<Room> rooms = new List<Room>();

        private List<RiddleData> riddleDataList = new List<RiddleData>();
        public Game()
        {
            LoadRiddles();
            InitializeRooms();
            InitializeEnemy();
        }

        public void Run()
        {
            GameUI.PlayerWelcome();

            InitPlayer();

            GameUI.DisplayStory(player.Name);

            rooms.ForEach(r => r.ProcessRoom(player));

            GameUI.DisplayFightIntro(player, enemy);

            FinalBattle();
        }

        public void LoadRiddles()
        {
            try
            {
                string path = @"data/riddles.json";
                string jsonString = File.ReadAllText(path);
                riddleDataList = JsonSerializer.Deserialize<List<RiddleData>>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Chyba při načítání hádanek: " + ex.Message);
                Environment.Exit(1);
            }
        }

        public void InitializeRooms()
        {
            foreach (var item in riddleDataList)
            {
                Room room = new Room(item);
                rooms.Add(room);
            }

            rooms.Sort((x, y) => x.Number.CompareTo(y.Number));
        }
        public void InitializeEnemy()
        {
            enemy = new Enemy("Stín", 15);
        }
        private void InitPlayer()
        {
            while (true)
            {
                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("❌ Jméno nemůže být prázdné. Zadej jméno znovu: ");
                    Console.ResetColor();
                    continue;
                }
                //Validace pouze písmen
                if (!input.All(char.IsLetter))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("❌ Jméno může obsahovat pouze písmena. Zadej jméno znovu: ");
                    Console.ResetColor();
                    continue;
                }

                player = new Player(input);
                return;
            }
        }
        public void FinalBattle()
        {
            GameResult battleResult = Battle();
            GameUI.DisplayGameResult(battleResult);
        }
        public GameResult Battle()
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                player.Attack(enemy);

                if (enemy.Health <= 0)
                    break;

                enemy.Attack(player);
            }

            return player.Health <= 0 ? GameResult.Defeat : GameResult.Victory;
        }
    }
}