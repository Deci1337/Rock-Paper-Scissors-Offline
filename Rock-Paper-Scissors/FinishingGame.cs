namespace rock_paper_scissors
{
    internal class FinishingGame
    {
        internal FinishingGame(string player, string bot, ref int Total, ref int Wins, ref int Loses)
        {
            Total++;
            Console.Clear();
            if (player == bot)
                Console.WriteLine("Tie. Press Anything to continue... ");
            switch (player, bot)
            {
                case ("Rock", "Paper"):
                    Console.WriteLine("You lost! Press Anything to continue... ");
                    Loses++;
                    break;
                case ("Rock", "Scissors"):
                    Console.WriteLine("You won! Press Anything to continue... ");
                    Wins++;
                    break;
                case ("Paper", "Scissors"):
                    Console.WriteLine("You lost! Press Anything to continue... ");
                    Loses++;
                    break;
                case ("Paper", "Rock"):
                    Console.WriteLine("You won! Press Anything to continue... ");
                    Wins++;
                    break;
                case ("Scissors", "Rock"):
                    Console.WriteLine("You lost! Press Anything to continue... ");
                    Loses++;
                    break;
                case ("Scissors", "Paper"):
                    Console.WriteLine("You won! Press Anything to continue... ");
                    Wins++;
                    break;
            }
        }
    }
}
