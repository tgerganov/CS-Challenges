using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Solution_A
{
    class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string Name, int Points)
        {
            this.Name = Name;
            this.Points = Points;
        }

        public int CompareTo(Player other)
        {
            if (other.Points > Points)
                return 1;
            else if (other.Points < Points)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            string s = "Name:" + Name + ", " + "Points: " + Points;
            return s;
        }
    }
}
