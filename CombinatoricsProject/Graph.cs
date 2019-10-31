using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsProject
{
    class Graph
    {
        List<Edge> edges = new List<Edge>();
        int vertexCount;

        public Graph(int vertices, List<Edge> edgeList)
        {
            edges = edgeList;
            vertexCount = vertices;
        }

        public int numberOfVertices()
        {
            //Returns the number of vertices in the graph
            return vertexCount;
        }
        public List<Edge> listEdges(int vertex)
        {
            //Returns all the edges with a connection to the vertex parameter
            
            
            List<Edge> edgeList = edges.Where(e => e.vertexTwo() == vertex).ToList();
            foreach(Edge e in edgeList)
            {
                e.switchVertices();
            }
            foreach(Edge e in edges.Where(e => e.vertexOne() == vertex).ToList())
            {
                edgeList.Add(e);
            }
            List<Edge> noDuplicateEdgeList = edgeList.Distinct().ToList();
            return noDuplicateEdgeList;
        }
        public void removeEdge(Edge e)
        {
            //Removes Edge e from edges
            edges.Remove(e);
        }      
        public int numberofEdgesRemaining()
        {
            return edges.Count;
        }
        public Edge smallerVertex(List<Edge> edgeList)
        {
            //Parameter should only pass through edges with the same v1 value.
            //Returns the edge with the smaller value for v2

            var smallerV = edgeList.Min(e => e.vertexTwo());
            Edge smallestEdge = edgeList.Where(e => e.vertexTwo() == smallerV).First();
            return smallestEdge;
        }
        public int findFirstRemainingVertex(List<Edge> eulerCircuitVertices)
        {
            //Get the first missing vertex edge in euler circuit.
            if (eulerCircuitVertices != null)
            {

                    foreach (Edge edge in eulerCircuitVertices)
                    {
                        List<Edge> tempEdges = listEdges(edge.vertexOne());
                        if (tempEdges.Count > 0)
                        {
                            return smallerVertex(tempEdges).vertexOne();
                        }
                    }
                
            }

            return 1;
        }
    }

}
