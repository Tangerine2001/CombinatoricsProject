using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsProject
{
    class Algorithms
    {
        Edge justRemovedEdge;


        public Algorithms()
        {
            justRemovedEdge = null;
        }

        public void Greedy(Graph g)
        {
            List<Edge> eulerCircuit = new List<Edge>();
            List<Edge> finalEulerCircuit = new List<Edge>();
            List<List<Edge>> iterations = new List<List<Edge>>();

            string outputString = "Euler Circuit is as follows: ";
            bool firstVertexEntered = false;
            //Gets the first vertex of circuit as vertexOne. The rest should all be vertexTwo.
            
            while (g.numberofEdgesRemaining() > 0)
            {
                if (!firstVertexEntered)
                {
                    //Finds first edge available from the vertices in the current eu
                    appendEulerCircuit(g, eulerCircuit, g.findFirstRemainingVertex(finalEulerCircuit));
                    finalEulerCircuit.Clear();
                    firstVertexEntered = true;
                }
                else if (g.listEdges(justRemovedEdge.vertexTwo()).Count > 0)
                {
                    appendEulerCircuit(g, eulerCircuit, justRemovedEdge.vertexTwo());
                }
                else
                {
                    appendEulerCircuit(g, eulerCircuit, justRemovedEdge.vertexTwo());
                    iterations.Add(new List<Edge>(eulerCircuit));
                    finalEulerCircuit = insertIterations(iterations);

                    eulerCircuit.Clear();
                    firstVertexEntered = false;

                }
            }
            iterations.Add(new List<Edge>(eulerCircuit));
            //eulerCircuit.Clear();

            //eulerCircuit = insertIterations(iterations);
            finalEulerCircuit.Clear();
            finalEulerCircuit = insertIterations(iterations);
            outputString += printEdges(finalEulerCircuit);
            Console.WriteLine(outputString);
            Console.ReadLine();
        }

        public void appendEulerCircuit(Graph g, List<Edge> eulerCircuit, int vertex)
        {
            //int v = g.smallerVertex(g.listEdges(vertex)).vertexOne();
            //int v = g.lowestRemainingEdge().vertexOne();            
            if (g.listEdges(vertex).Count > 0)
            {
                List<Edge> tempEdges = g.listEdges(vertex);
                Edge chosenEdge = g.smallerVertex(tempEdges);
                justRemovedEdge = chosenEdge;
                eulerCircuit.Add(chosenEdge);
                g.removeEdge(chosenEdge);
            }
        }    
        public string printEdges(List<Edge> edges)
        {
            string output = "";
            for (int i = 0; i < edges.Count; i++)
            {
                output += edges[i].vertexOne() + ", ";
            }
            output += edges[edges.Count - 1].vertexTwo();
            return output;
        }
        public List<Edge> insertIterations(List<List<Edge>> iterations)
        {
            List<Edge> final = new List<Edge>();
            if (iterations.Count > 0)
            {
                List<Edge> temp = new List<Edge>(iterations[0]);
                int totalNumberOfEdges = totalEdges(iterations);
                
                while (temp.Count < totalNumberOfEdges)
                {
                    for (int l = 1; l < iterations.Count; l++)
                    {
                        int i = iterations[l][0].vertexOne();
                        int j = temp.FindIndex(x => x.vertexOne() == i);
                        for (int k = iterations[l].Count - 1; k >= 0; k--)
                        {
                            temp.Insert(j, iterations[l][k]);
                        }
                        //iterations.Remove(iterations[1]);
                    }
                }
                final = temp;
            }


            return final;
        }
        public int totalEdges(List<List<Edge>> list)
        {
            int total = 0;
            foreach(List<Edge> e in list)
            {
                total += e.Count;
            }
            return total;
        }
    }
}
