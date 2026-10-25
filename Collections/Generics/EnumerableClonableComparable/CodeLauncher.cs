using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics.EnumerableClonableComparable
{
    internal class CodeLauncher
    {
        public static void Launch()
        {
            Team team = new Team();

            Player player1 = new Player("Koko", 150);
            team.Add(player1);
            Console.WriteLine(player1);

            Player player2 = new Player("Davo", 250);
            team.Add(player2);
            Console.WriteLine(player2);

            Player player3 = new Player("Mash", 110);
            team.Add(player3);
            Console.WriteLine(player3);

            team.Sort();
            Console.WriteLine("==================== PLAYERS SORTING BY SCORE ----------------------");
            foreach (Player player in team)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("----------------- CLONE CHECK -------------------");
            Player original = new Player("Gago", 1500);
            Player clone = (Player)original.Clone();
            Console.WriteLine($"Original player: {original}");
            Console.WriteLine($"Cloned player: {clone}");
        }
    }
}
