using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual2OPT.GraphAlgorithms
{
    public class VertexCover
    {
        // No. of vertices
        public int V;

        // Array of lists for
        // Adjacency List Representation
        public List<int>[] adj;

        // Constructor
        public VertexCover(int v)
        {
            V = v;
            adj = new List<int>[v];

            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        //Function to add an edge into the graph
         
        public void addEdge(int v, int w)
        {
            // Add w to v's list.
            adj[v].Add(w);

            //Graph is undirected
            adj[w].Add(v);
        }

        // The function to print
        // vertex cover
        public void printVertexCover()
        {
            // Initialize all vertices
            // as not visited.
            bool[] visited = new bool[V];

            // Consider all edges one
            // by one
            for (int u = 0; u < V; u++)
            {
                // An edge is only picked
                // when both visited[u]
                // and visited[v] are false
                if (visited[u] == false)
                {
                    // Go through all adjacents
                    // of u and pick the first
                    // not yet visited vertex
                    // (We are basically picking
                    // an edge (u, v) from remaining
                    // edges.
                    foreach (int i in adj[u])
                    {
                        int v = i;
                        if (visited[v] == false)
                        {
                            // Add the vertices (u, v)
                            // to the result set. We
                            // make the vertex u and
                            // v visited so that all
                            // edges from/to them would
                            // be ignored
                            visited[v] = true;
                            visited[u] = true;
                            break;
                        }
                    }
                }
            }

            // Print the vertex cover
            for (int j = 0; j < V; j++)
                if (visited[j])
                    Console.Write(j + " ");
        }
    }
}
