using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Node
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Name { get; set; }
        public Point Location { get; set; }
        public bool Visited { get; set; } = false;
        public bool Spanned { get; set; } = false;
        public decimal Profit { get; set; }
        public int Degree { get; set; } //out degree
    }

    public class NodeFactory
    {
        private readonly Random _random;

        public NodeFactory(Random random)
        {
            _random = random;
        }
        public Node GetNode(int id, string name)
        {
            Node result = new Node() { ID=id,ParentID=id,Name=name, 
                        Location = new Point(_random.Next(10,630),_random.Next(10,470))};
                               
            return result;

        }
        public Node[] GetNodes(int size)
        {
            Node[] result = new Node[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = GetNode(i, $"{(char)(i + 65)}");
            }
            return result;
        }
    }
}
