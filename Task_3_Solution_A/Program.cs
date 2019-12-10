using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Solution_A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> leaderboard = new List<Player>
            {
                new Player("Ole", 300),
                new Player("Peter", 100),
                new Player("Per", 500),
                new Player("Finn", 200),
                new Player("Josephine", 400)
            };

            var bestPlayerPoints = leaderboard.Max(p => p.Points);
            var worstPlayerPoints = leaderboard.Min(p => p.Points);

            Console.WriteLine();
            Console.WriteLine("The leaderboard before it is sorted:");
            Console.WriteLine("======================");
            leaderboard.ForEach(Console.WriteLine);
            Console.WriteLine();

            leaderboard.Sort();
            Console.WriteLine("The leaderboard after it is sorted by max points (desc):");
            Console.WriteLine("======================");
            leaderboard.ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("The points of the best player are: " + bestPlayerPoints);

            Console.WriteLine("The points of the worst player are: " + worstPlayerPoints);
            Console.WriteLine();

            var bestPlayerQuery = from n in leaderboard where n.Points == leaderboard.Max(p => p.Points) select n;
            foreach(Player p in bestPlayerQuery)
            {
                Console.WriteLine("The highest ranked player is: {0}", p.Name);
            }

            var worstPlayerQuery = from n in leaderboard where n.Points == leaderboard.Min(p => p.Points) select n;
            foreach (Player p in worstPlayerQuery)
            {
                Console.WriteLine("The lowest ranked player is: {0}", p.Name);
            }

            Console.ReadKey();
        }
    }
}
