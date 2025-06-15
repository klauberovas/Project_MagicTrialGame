using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicTrialGame.Interfaces;
using MagicTrialGame.UI;

namespace MagicTrialGame.Models
{
    public class Room
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public IRiddle Riddle { get; set; }
        public Artifact RoomArtifact { get; set; }
        private const int MaxAttempts = 3;

        public Room(RiddleData riddleData)
        {
            Number = riddleData.RoomNumber;
            Name = riddleData.RoomName;
            Riddle = new Riddle(riddleData.Question, riddleData.Answer, riddleData.Hint, riddleData.Options);
            RoomArtifact = new Artifact(riddleData.Artifact, riddleData.Spell);
        }
        public void ProcessRoom(Player player)
        {
            //  var currentRoom = Rooms.Find(r => r.Number == CurrentRoomIndex);
            // var currentRiddle = currentRoom.Riddle;

            GameUI.DisplayRoom(this);
            GameUI.DisplayRiddle(Riddle.Question);
            GameUI.DisplayHint(Riddle.Hint);
            GameUI.DisplayOptions(Riddle.Options);

            int attemps = 0;
            bool isCorrectAnswer = false;

            while (attemps < MaxAttempts && !isCorrectAnswer)
            {
                // vrátí volbu od Usera
                var userInput = GameUI.GetUserInput();

                //vyhodnotí odpověď
                if (userInput != null)
                {
                    isCorrectAnswer = ProcessAnswer(Riddle, userInput);
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
                player.Artifacts.Add(RoomArtifact);
                GameUI.DisplayAward(this.RoomArtifact);
            }
            // vyčerpání limitu
            else
            {
                GameUI.DisplayMessage($"🚫 Vyčerpali jste všechny pokusy {MaxAttempts} pokusy.", ConsoleColor.DarkRed);
            }
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
        // public RoomResult ProcessRoom(Player player)
        // {
        //     // Logika pro zpracování místnosti
        //     // 3 pokusy, vyhodnocení odpovědi
        // }

    }
}