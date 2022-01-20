using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT.GraphAlgorithms
{
    internal class City
    {
        private static Random rand = new Random();

        public City(int cityName)
        {
            X = rand.NextDouble() * 100;
            Y = rand.NextDouble() * 100;
            CityName = cityName;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public int CityName { get; private set; }
    }

    internal class Stop
    {
        public Stop(City city)
        {
            City = city;
        }


        public Stop Next { get; set; }
        public City City { get; set; }


        public Stop Clone()
        {
            return new Stop(City);
        }


        public static double Distance(Stop first, Stop other)
        {
            return Math.Sqrt(
                Math.Pow(first.City.X - other.City.X, 2) +
                Math.Pow(first.City.Y - other.City.Y, 2));
        }


        //list of nodes, including this one, that we can get to
        public IEnumerable<Stop> CanGetTo()
        {
            var current = this;
            while (true)
            {
                yield return current;
                current = current.Next;
                if (current == this) break;
            }
        }


        public override bool Equals(object obj)
        {
            return City == ((Stop)obj).City;
        }


        public override int GetHashCode()
        {
            return City.GetHashCode();
        }


        public override string ToString()
        {
            return City.CityName.ToString();
        }
    }
}
