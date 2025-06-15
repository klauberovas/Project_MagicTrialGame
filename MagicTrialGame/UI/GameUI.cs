using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagicTrialGame.Models;

namespace MagicTrialGame.UI
{
    public static class GameUI
    {

        public static void PlayerWelcome()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Vítej cizinče ve hře ZKOUŠKA ČARODĚJE. Pověz mi své jméno: ");
        }
        public static void DisplayStory(string name)
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
            Console.WriteLine($"📜 {name.ToUpper()}, po letech studia magie nadešel Tvůj den zkoušky Mistra.");
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
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dej [enter] pro pokračování... ");
            Console.ReadLine();
        }
        public static void DisplayRoom(Room room)
        {
            Console.Clear();

            // Magický efekt vstupu
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("✨ Vstupujete do nové místnosti...");
            Thread.Sleep(800);
            Console.Clear();

            // Hlavička místnosti s rámečkem
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════════╗");
            Console.WriteLine($"║        🏰 MÍSTNOST {room.Number}: {room.Name.ToUpper().PadRight(22)} ║");
            Console.WriteLine("╚══════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine();
        }
        public static void DisplayRiddle(string question)
        {
            // Dramatická pauza
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("🔮 Magická hádanka se objevuje...");
            Thread.Sleep(1000);
            Console.WriteLine();

            // Stylový rámeček pro hádanku
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┌─────────────────────────────────────────┐");
            Console.WriteLine("│            🧩 HÁDANKA 🧩                │");
            Console.WriteLine("└─────────────────────────────────────────┘");
            Console.ResetColor();

            Console.WriteLine();

            // Samotná otázka
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"🤔 \"{question}\"");
            Console.ResetColor();

            Console.WriteLine();
        }
        public static void DisplayOptions(List<string> options)
        {
            foreach (var o in options)
            {
                Console.WriteLine($"{o}");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Zadej vybranou odpověď, např. A");
            Console.ResetColor();
        }
        public static string GetUserInput(string prompt) => "";
        public static void DisplayGameResult(GameResult result, Player player) { }
    }
}