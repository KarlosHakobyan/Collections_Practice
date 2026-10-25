using System.Collections;
using System.Collections.Generic;

namespace Collections.Generics.EnumerableClonableComparable
{
    internal class Team : IEnumerable<Player>
    {
        private List<Player> players = new List<Player>();

        public void Add(Player player)
        {
            players.Add(player);
        }

        
        public void Sort()
        {
            players.Sort();
        }

        
        public IEnumerator<Player> GetEnumerator()
        {
            foreach (var player in players)
            {
                yield return player;
            }
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}