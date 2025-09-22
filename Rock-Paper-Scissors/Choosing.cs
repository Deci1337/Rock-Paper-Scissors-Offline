namespace rock_paper_scissors
{
    internal class Choosing
    {
        string Choosen = "";
        internal Choosing() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose Your Turn: ");
            WriteTextWithBorder("1 - Rock    ", ConsoleColor.DarkGreen);
            WriteTextWithBorder("2 - Paper   ", ConsoleColor.DarkGreen);
            WriteTextWithBorder("3 - Scissors", ConsoleColor.DarkGreen);
            while (Choosen == "")
            {
                Choose(ref Choosen);
            }
            for(int i  = 3; i >= 1; i--)
            {
                Console.SetCursorPosition(18, 5);
                Console.Write($"Time Remain: {i}");
                Thread.Sleep(1000);
            }
        }
        internal string Selection() => Choosen;
        private static void WriteTextWithBorder(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            string line = "+" + new String('-', text.Length + 2) + "+";
            Console.WriteLine(line);
            Console.WriteLine("| " + text + " |");
            Console.WriteLine(line);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void Choose(ref string Choosen)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.Clear();
            switch (keyInfo.Key) 
            {
                case (ConsoleKey.D1):
                    Console.WriteLine("Turn: Rock");
                    WriteTextWithBorder("1 - Rock    ", ConsoleColor.Green);
                    WriteTextWithBorder("2 - Paper   ", ConsoleColor.White);
                    WriteTextWithBorder("3 - Scissors", ConsoleColor.White);
                    Choosen = "Rock";
                    break;
                case (ConsoleKey.D2):
                    Console.WriteLine("Turn: Paper");
                    WriteTextWithBorder("1 - Rock    ", ConsoleColor.White);
                    WriteTextWithBorder("2 - Paper   ", ConsoleColor.Green);
                    WriteTextWithBorder("3 - Scissors", ConsoleColor.White);
                    Choosen = "Paper";
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("Turn: Scissors");
                    WriteTextWithBorder("1 - Rock    ", ConsoleColor.White);
                    WriteTextWithBorder("2 - Paper   ", ConsoleColor.White);
                    WriteTextWithBorder("3 - Scissors", ConsoleColor.Green);
                    Choosen = "Scissors";
                    break;
                default:
                    Console.WriteLine("Wrong. Choose again!");
                    WriteTextWithBorder("1 - Rock    ", ConsoleColor.DarkRed);
                    WriteTextWithBorder("2 - Paper   ", ConsoleColor.DarkRed);
                    WriteTextWithBorder("3 - Scissors", ConsoleColor.DarkRed);
                    break;
            }

        }
    }
}
