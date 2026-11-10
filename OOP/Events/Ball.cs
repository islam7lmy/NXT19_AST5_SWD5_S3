using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Events
{
    struct Location
    {
        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString() => $"({X} , {Y} , {Z})";
    }

    internal class Ball
    {
        private Location location;

        public Location Location
        {
            get => location;
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    //LocationChanged.Invoke();
                    LocationChanged(value);
                }

            }
        }

        public event Action<Location> LocationChanged;
    }

    class Player
    {
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }

        public string Name { get; set; }
        public string Team { get; set; }

        public override string ToString() => $"Player : {Name} in team : {Team}";

        public void Run(Location newlocation)
        {
            Console.WriteLine($"{this.ToString()} is Running Towards >>> {newlocation}");
        }

    }

    class Refree
    {
        public Refree(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString() => $"Refree : {Name}";

        public void Look(Location newlocation)
        {
            Console.WriteLine($"{this.ToString()} is Looking Towards >>> {newlocation}");
        }
    }

}
