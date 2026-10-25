using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generics.EnumerableClonableComparable
{
    internal class Player : IComparable<Player> , ICloneable
    {
        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public string Name { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"Player: {Name}, Score: {Score}";
        }

        public int CompareTo(Player otherPlayer)
        {
            return otherPlayer.Score.CompareTo(Score);
        }
        public object Clone()
        { 
            return new Player(Name, Score);
        }

    }
}
