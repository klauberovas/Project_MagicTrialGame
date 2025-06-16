using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MagicTrialGame.Interfaces;
using MagicTrialGame.UI;
using Microsoft.VisualBasic;

namespace MagicTrialGame.Models
{
    public class Game
    {
        private Player Player;
        private List<Room> Rooms;
        private Enemy Enemy;
        public Game()
        {
            string path = @"data/riddles.json";
            string jsonString = File.ReadAllText(path);
            List<RiddleData> riddles = JsonSerializer.Deserialize<List<RiddleData>>(jsonString);

            Rooms = new List<Room>();
            foreach (var item in riddles)
            {
                Room room = new Room(item);
                Rooms.Add(room);
            }
            Rooms.Sort((x, y) => x.Number.CompareTo(y.Number));

            // Inicializace Stína
            Enemy = new Enemy("Stín", 15);
        }

        public void Run()
        {
            GameUI.PlayerWelcome();

            InitPlayer();

            GameUI.DisplayStory(Player.Name);

            Rooms.ForEach(r => r.ProcessRoom(Player));

            GameUI.DisplayFightIntro(Player, Enemy);

            FinalBattle();
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

                Player = new Player(input);
                return;
            }
        }
        public void FinalBattle()
        {
            while (Player.Health > 0 && Enemy.Health > 0)
            {
                Player.Attack(Enemy);

                if (Enemy.Health <= 0)
                    break;

                Enemy.Attack(Player);
            }

            if (Player.Health <= 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║              💀 PROHRA 💀              ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Bohužel vyhrál Stín... Zkus to příště.");
            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║             🎉 VÍTĚZSTVÍ! 🎉           ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Gratuluji!!! Porazil jsi Stína!");
            }

            Console.ResetColor();
            Console.WriteLine();
        }
    }
}