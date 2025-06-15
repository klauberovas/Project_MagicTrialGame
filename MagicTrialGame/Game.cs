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
        }

        public void Run()
        {
            GameUI.PlayerWelcome();
            InitPlayer();
            GameUI.DisplayStory(Player.Name);

            foreach (var room in Rooms)
            {
                room.ProcessRoom(Player);
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
        // public void FinalBattle();
    }
}