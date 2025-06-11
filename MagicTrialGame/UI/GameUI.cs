using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicTrialGame.Models;

namespace MagicTrialGame.UI
{
    public static class GameUI
    {
        public static void DisplayWelcome()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("             ★ ✦ ◆ ✦ ★");
            Console.WriteLine("╔══════════════════════════════════════╗");
            Console.WriteLine("║       🧙  ZKOUŠKA ČARODĚJE 🧙        ║");
            Console.WriteLine("╚══════════════════════════════════════╝");
            Console.WriteLine("             ★ ✦ ◆ ✦ ★");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("📜 Po letech studia magie nadešel Tvůj den zkoušky Mistra.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vstupuješ do starobylé knihovny plné kouzel a tajemství.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Čeká Tě 5 komnat s náročnými hádankami. S každou správnou odpověďí");
            Console.WriteLine("získáš kouzlo a artefakt, které Ti pomohou v závěrečném souboji.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("👤 V poslední komnatě tě čeká Stín - padlý učedník.");
            Console.WriteLine("⚔️  Porazíš ho? Nebo ho dokážeš zachránit?");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Vstoupit do knihovny? ");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("[Enter]");
            Console.ResetColor();

            Console.ReadLine();
        }
        public static void DisplayRoom(Room room)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"==== MÍSTNOST {room.Number}: {room.Name.ToUpper()} ====");
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void DisplayRiddle()
        {
            
        }
        public static string GetUserInput(string prompt) => "";
        public static void DisplayGameResult(GameResult result, Player player) { }
    }
}