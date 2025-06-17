using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MagicTrialGame.Models
{
    public class RiddleLoader
    {
        private const string RIDDLES_PATH = @"data/riddles.json";

        public List<RiddleData> LoadRiddles()
        {
            try
            {
                string jsonString = File.ReadAllText(RIDDLES_PATH);
                return JsonSerializer.Deserialize<List<RiddleData>>(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Chyba při načítání hádanek: " + ex.Message);
                Environment.Exit(1);
                return null;
            }
        }
    }
}