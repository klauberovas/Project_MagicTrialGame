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
        private int CurrentRoomIndex = 1;
        private const int MaxAttempts = 3;

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

        public void Run()
        {
            GameUI.PlayerWelcome();
            InitPlayer();
            GameUI.DisplayStory(Player.Name);
            while (CurrentRoomIndex < Rooms.Count())
            {
                ProcessRoom();
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
            GameUI.DisplayHint(currentRiddle.Hint);
            GameUI.DisplayOptions(currentRiddle.Options);

            int attemps = 0;
            bool isCorrectAnswer = false;

            while (attemps < MaxAttempts && !isCorrectAnswer)
            {
                // vrátí volbu od Usera
                var userInput = GameUI.GetUserInput();

                //vyhodnotí odpověď
                if (userInput != null)
                {
                    isCorrectAnswer = ProcessAnswer(currentRiddle, userInput);
                }
                else
                {
                    GameUI.DisplayMessage("⚠️  Neplatná odpověď. Zadej znovu.", ConsoleColor.Cyan);
                }

                if (!isCorrectAnswer)
                {
                    attemps++;
                }
            }

            // přiřazení artefaktu
            if (isCorrectAnswer)
            {
                Player.Artifacts.Add(currentRoom.RoomArtifact);
                GameUI.DisplayAward(currentRoom.RoomArtifact);
            }
            // vyčerpání limitu
            else
            {
                GameUI.DisplayMessage($"🚫 Vyčerpali jste všechny pokusy {MaxAttempts} pokusy.", ConsoleColor.DarkRed);
            }
            CurrentRoomIndex++;

            GameUI.ContinuePrompt();
        }

        private bool ProcessAnswer(IRiddle riddle, string answer)
        {
            if (riddle.CheckAnswer(answer))
            {
                GameUI.DisplayMessage("✅ Výborně!!! Správná odpověď.", ConsoleColor.Green);
                return true;
            }
            else
            {
                GameUI.DisplayMessage("❌ Nesprávná odpověď.", ConsoleColor.Red);
                return false;
            }
        }

        // public void FinalBattle();
    }
}