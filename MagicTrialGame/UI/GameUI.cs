using System;
using System.Collections.Generic;
using System.Drawing;
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

            //Hlavní titulek
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                          ║");
            Console.WriteLine("║              🧙 ZKOUŠKA ČARODĚJE 🧙                      ║");
            Console.WriteLine("║                                                          ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════╝");
            Console.WriteLine();

            // Uvítací text
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("✨ Vítej, cizinče, v mystickém světě kouzel a magie! ✨");
            Console.WriteLine();

            // Výzva k zadání jména
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("🔮 Pověz mi své jméno, odvážný dobrodruhu: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DisplayStory(string name)
        {
            Console.Clear();
            Console.WriteLine();

            // Příběhový úvod
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"📜 {name}, po letech studia magie nadešel Tvůj den zkoušky Mistra.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vstupuješ do starobylé knihovny plné kouzel a tajemství.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Čeká Tě 5 komnat s náročnými hádankami. Každá správná odpověď");
            Console.WriteLine("Ti odhalí mocný artefakt, jehož magická síla posílí Tvou moc");
            Console.WriteLine("pro závrečný souboj s temným čarodějem.");
            Console.WriteLine();

            // Varování před finálním soubojem
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("👤 V poslední komnatě tě čeká Stín - padlý učedník.");
            Console.WriteLine("⚔️  Porazíš ho? Nebo ho dokážeš zachránit?");
            Console.WriteLine();

            // Výzva k pokračování
            ContinuePrompt();
        }
        public static void ContinuePrompt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Pro pokračování stiskni klávesu nebo ESC pro ukončení.");
            Console.ForegroundColor = ConsoleColor.White;

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Program byl ukončen.");
                Environment.Exit(0);
            }

        }
        public static void DisplayRoom(Room room)
        {
            Console.Clear();

            // Magický efekt vstupu
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("✨ Vstupuješ do nové místnosti...");
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
        public static void DisplayHint(string hint)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Nápověda: {hint}");
            Console.ResetColor();
        }
        public static void DisplayOptions(List<string> options)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var o in options)
            {
                Console.WriteLine($"{o}");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Zadej vybranou odpověď, např. A.");
            Console.ResetColor();
        }
        public static string GetUserInput()
        {
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKeyInfo input = Console.ReadKey();
            Console.WriteLine();

            return input.Key switch
            {
                ConsoleKey.A => "A",
                ConsoleKey.B => "B",
                ConsoleKey.C => "C",
                ConsoleKey.D => "D",
                _ => null
            };
        }
        public static void DisplayMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void DisplayAward(string artifactName, int magicPower, string name, int abilityPower)
        {
            Console.WriteLine();

            // ocenění
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║                    ✨ ÚSPĚCH! ✨                       ║");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();

            Console.WriteLine($"🏆 {name}, získal/a jsi artefakt: {artifactName}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"⚡ Magická síla artefaktu: +{magicPower} bodů");
            Console.WriteLine();

            // Celkový stav
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"🔮 Tvá celková magická síla: {abilityPower} bodů");
            Console.WriteLine();

            Console.ResetColor();
        }
        public static void DisplayNoAward(int abilityPower)
        {
            Console.WriteLine();

            // rámeček
            // Rámček pro neúspěch
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                   ❌ NESPRÁVNĚ ❌                     ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine();

            // Povzbuzující zpráva
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("💭 Bohužel, tentokrát to nevyšlo...");
            Console.WriteLine("🎯 Ale nevzdávej se! Každá chyba tě učí něco nového.");
            Console.WriteLine();

            // Celkový stav
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"🔮 Tvá současná magická síla: {abilityPower} bodů");
            Console.WriteLine();

            Console.ResetColor();
        }
        public static void DisplayFightIntro(Player player, Enemy enemy)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Nyní Tě čeká finální souboj se Stínem.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{player.Name}, Tvé aktuální stavové konto je: ");
            Console.WriteLine($"Počet životů: {player.Health}");
            Console.WriteLine($"Magická síla: {player.AbilityPower}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Stínovo stavové konto je:");
            Console.WriteLine($"Počet životů: {enemy.Health}");
            Console.WriteLine($"Magická síla: {enemy.AbilityPower}");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Jsi připraven?");

            Console.ForegroundColor = ConsoleColor.Cyan;

            ContinuePrompt();
        }
        public static void DisplayGameResult(GameResult result, Player player) { }
    }
}