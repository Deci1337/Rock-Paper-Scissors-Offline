/* 
 * By Deci1337 *
 * My First mini project *
 * https://github.com/Deci1337 *
 * More info *
*/
namespace rps
{
    using rock_paper_scissors;
    using System;
    using System.Threading;

    class Program
    {
        // For next update ;)
        //public int Wins { get; private set; }
        //public int Loses { get; private set; }
        //public int Total { get; private set; }
        static void Main()
        {
            int Total = 0, Wins = 0, Loses = 0;
            while (true)
            {
                Choosing choosing = new Choosing();
                Opponent opponent = new Opponent();

                string chosen = choosing.Selection();
                DrawSubjects drawSubjects = new DrawSubjects(chosen);
                Console.ReadKey();
                FinishingGame finishingGame = new FinishingGame(chosen, opponent.RandomTurn(), ref Total, ref Wins, ref Loses);
                Console.WriteLine("Total: {2}\nWins : {0}\nLoses:{1}", Wins, Loses, Total);
                Console.ReadKey(); // Waiting user input
                Console.Clear();
            }
        }
    }
}

