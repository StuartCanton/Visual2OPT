using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visual2OPT.GraphAlgorithms;

namespace Visual2OPT.TestGraphAlgorithms
{
    internal class TestVertexCover
    {
        public TestVertexCover()
        {
            // Create a graph given in
            // the above diagram
            VertexCover g = new VertexCover(7);
            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 3);
            g.addEdge(3, 4);
            g.addEdge(4, 5);
            g.addEdge(5, 6);

            g.printVertexCover();
        }
    }
}
