using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MagicTrialGame.UI;

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
        public void Run()
        {
            GameUI.DisplayWelcome();
            InitPlayer();
            GameUI.DisplayRoom(Rooms.Find(r => r.Number == CurrentRoomIndex));
            GameUI.DisplayRiddle(Rooms
            .Where(r => r.Number == CurrentRoomIndex)
            .Select(r => r.Riddle?.Question)
            .FirstOrDefault());
        }

        private void InitPlayer()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Zadej jméno: ");
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
        public void ProcessRoom(int roomNumber)
        {

        }
        // public void FinalBattle();
    }
}