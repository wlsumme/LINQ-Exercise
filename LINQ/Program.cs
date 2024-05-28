namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string> {"Pac-Man", "Space Invaders", "Galaga", "Donkey Kong", "Asteroids" };

            var orderedGames = games.OrderBy(x => x.Length).ToList();

            foreach (var x in orderedGames)
            {
                Console.WriteLine(x);
            }
        }
    }
}
