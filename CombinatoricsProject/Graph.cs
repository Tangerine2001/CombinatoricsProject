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
        List<List<Edge>> removedEdgeSets = new List<List<Edge>>();
        List<int> vertices = new List<int>();
        int vertexCount;

        public Graph(int vert, List<Edge> edgeList)
        {
            edges = edgeList;
            vertexCount = vert;
            vertices = vertexList(vert);
        }

        public Graph Copy()
        {
            Graph copy = (Graph)this.MemberwiseClone();
            copy.edges = new List<Edge>(edges);
            copy.removedEdgeSets = new List<List<Edge>>(removedEdgeSets);
            copy.vertexCount = this.vertexCount;
            copy.vertices = new List<int>(vertices);
            return copy;
        }

        public int numberOfVertices()
        {
            //Returns the number of vertices in the original graph
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
        public void removeEdges(List<Edge> edgeList)
        {
            removedEdgeSets.Add(edgeList);
            foreach(Edge e in edgeList)
            {
                removeEdge(e);
            }
        }
        public void removeVertex(int vertex)
        {
            vertices.Remove(vertex);
        }
        public void addEdge(Edge e)
        {
            //Adds back an edge
            edges.Add(e);
        }
        public void addBackEdgeSet(Edge chosenEdge)
        {
            //Adds back an edge set when hamiltonian path isn't satisfied. Doesn't add back chosen edge.
            if (removedEdgeSets.Count > 0)
            {
                foreach (Edge e in removedEdgeSets[removedEdgeSets.Count - 1])
                {
                    if (e != chosenEdge)
                    {
                        edges.Add(e);
                    }
                }
                removedEdgeSets.Remove(removedEdgeSets[removedEdgeSets.Count - 1]);
            }
        }
        public int numberofEdgesRemaining()
        {
            return edges.Count;
        }
        public int numberOfVerticesRemaining()
        {
            //Returns the number of untouched vertices
            return vertices.Count;
        }
        public Edge smallerVertex(List<Edge> edgeList)
        {
            //Parameter should only pass through edges with the same v1 value.
            //Returns the edge with the smaller value for v2

            var smallerV = edgeList.Min(e => e.vertexTwo());
            Edge smallestEdge = edgeList.Where(e => e.vertexTwo() == smallerV).First();
            return smallestEdge;
        }
        public Edge selectEdge(List<Edge> edgeList, int index)
        {
            Edge e = edgeList[index];
            
            removeEdges(edgeList);
            removeVertex(e.vertexOne());
            removeVertex(e.vertexTwo());
            return e;
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
        public List<int> vertexList(int vertexCount)
        {
            List<int> v = new List<int>();
            for(int i = 1; i < vertexCount + 1; i++)
            {
                v.Add(i);
            }
            return v;
        }
    }

}
