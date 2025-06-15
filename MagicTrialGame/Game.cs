using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MagicTrialGame.UI;
using Microsoft.VisualBasic;

namespace MagicTrialGame.Models
{
    public class Game
    {
        private Player Player;
        private List<Room> Rooms;
        private int CurrentRoomIndex = 1;

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
        }

        private void InitPlayer()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == null || input == "")
                {
                    Console.WriteLine("Zadej jméno znovu:");
                    continue;
                }
                else
                {
                    Player = new Player(input);
                    return;
                }
            }
        }
        private void ProcessRoom()
        {
            var currentRoom = Rooms.Find(r => r.Number == CurrentRoomIndex);
            var currentRiddle = currentRoom.Riddle;

            GameUI.DisplayRoom(currentRoom);
            GameUI.DisplayRiddle(currentRiddle.Question);
            GameUI.DisplayOptions(currentRiddle.Options);

            int attemps = 1;
            bool isCorrectAnswer = false;
            while (attemps <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                ConsoleKeyInfo input = Console.ReadKey();

                Console.WriteLine();

                switch (input.Key)
                {
                    case ConsoleKey.A:
                        if (currentRiddle.CheckAnswer("A"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Výborně!!! Správná odpověď.");
                            isCorrectAnswer = true;
                            attemps = 4;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nesprávná odpověď.");
                            attemps++;
                        }
                        break;
                    case ConsoleKey.B:
                        if (currentRiddle.CheckAnswer("B"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Výborně!!! Správná odpověď.");
                            isCorrectAnswer = true;
                            attemps = 4;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nesprávná odpověď.");
                            attemps++;
                        }
                        break;
                    case ConsoleKey.C:
                        if (currentRiddle.CheckAnswer("C"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Výborně!!! Správná odpověď.");
                            isCorrectAnswer = true;
                            attemps = 4;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nesprávná odpověď.");
                            attemps++;
                        }
                        break;
                    case ConsoleKey.D:
                        if (currentRiddle.CheckAnswer("D"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Výborně!!! Správná odpověď.");
                            isCorrectAnswer = true;
                            attemps = 4;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nesprávná odpověď.");
                            attemps++;
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Neplatná odpověď. Zadej znovu.");
                        attemps++;
                        break;
                }
            }

        }

        // public void FinalBattle();

        public void Run()
        {
            GameUI.PlayerWelcome();
            InitPlayer();
            GameUI.DisplayStory(Player.Name);
            ProcessRoom();
        }

    }
}