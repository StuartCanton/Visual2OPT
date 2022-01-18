using System.Drawing;
using System.Text;

namespace SharedLibrary.Models
{
    public class Edge
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Distance { get; set; }
        public decimal Profit { get; set; }
        public bool Visited { get; set; } = false;
        public Color Colour { get; set; }
        public bool isVisible { get; set; } = false;

    }

    public class EdgeFactory
    {
        private readonly Random _random;

        public EdgeFactory(Random random)
        {
            _random = random;
        }

        public Edge GetEdge(Node s, Node e)
        {
            return new Edge { Start = s.ID, End = e.ID, Distance= calcDistance (s,e), 
                                Colour = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256)) };
        }


        private int calcDistance(Node a, Node b)
        {
            double dx = a.Location.X - b.Location.X;
            double dy = a.Location.Y - b.Location.Y;
            double d1 = Math.Sqrt(dx * dx + dy * dy);
            return (int)Math.Round(d1);
        }

        public Edge[] GetEdges(Node[] nodes)
        {
            List<Edge> edges = new List<Edge>();
            for (int i = 0; i < nodes.Length; i++)
            {
                for (int j = nodes.Length - 1; j >= i; j--)
                {
                    if(i!=j)
                        edges.Add(GetEdge(nodes[i], nodes[j]));
                        //edges.Add(new Edge { Start = nodes[i].ID, End = nodes[j].ID, Distance = calcDistance(nodes[i], nodes[j]) });
                }
            }
            return edges.ToArray();
        }

        //public Edge[] EdgesFromMatrix
    }

    public static partial class Extensions
    {
        public static string EdgeArrayToString(this Edge[] edges)
        {
            string from, to;
            StringBuilder sb = new();
            foreach (var item in edges)
            {
                from = $"{(char)(item.Start+65)}";
                to = $"{(char)(item.End + 65)}";
                sb.AppendLine($"start:{from},end:{to},cost:{item.Distance}");
            }

            return sb.ToString();
        }
    }
}