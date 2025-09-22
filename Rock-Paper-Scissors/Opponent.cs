namespace rock_paper_scissors
{
    internal class Opponent
    {
        internal string RandomTurn()
        {
            String[] strings = { "Rock", "Paper", "Scissors" };
            Random random = new Random();
            int randomIndex = random.Next(strings.Length - 1);
            return strings[randomIndex];
        }
    }
}
