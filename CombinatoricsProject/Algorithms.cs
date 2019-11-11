using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CombinatoricsProject
{
    class Algorithms
    {
        Edge justRemovedEdge;
        Random rand;

        public Algorithms()
        {
            justRemovedEdge = null;
            rand = null;
        }

        public string Greedy(Graph g)
        {
            DateTime start = DateTime.Now;
            List<Edge> eulerCircuit = new List<Edge>();
            List<Edge> finalEulerCircuit = new List<Edge>();
            List<List<Edge>> iterations = new List<List<Edge>>();
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
            DateTime stop = DateTime.Now;
            TimeSpan timeDiff = (stop - start);
            string outputString = String.Format("Time Taken: {0}:{1}:{2}:{3}\n", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds) + "Euler Circuit: " + printEdges(finalEulerCircuit) + "\nDistance: " + pathDistance(finalEulerCircuit);
            return outputString;
        }
        public string RandomHamiltonian(Graph g)
        {
            //EXTREMELY INEFFICIENT METHOD OF FINDING HAMILTONIAN PATH. ITS LIKE BRUTE FORCE BUT WORSE. DONT USE ON GRAPH WITH MORE THAN 40 VERTICES.
            DateTime start = DateTime.Now;
            Graph gCopy = g.Copy();

            List<Edge> hamPath = findRandomHamiltonianPath(gCopy, 1);
            DateTime stop = DateTime.Now;
            TimeSpan timeDiff = (stop - start);
            string outputString = String.Format("Time Taken: {0}:{1}:{2}:{3}\n", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds) + "Path: " + printEdges(hamPath) + "\nDistance: " + pathDistance(hamPath);
            return outputString;
        }
        public List<Edge> findRandomHamiltonianPath(Graph g, int startVertex)
        {
            //Make copy of the copy to pass into another run if the the current run fails
            Graph gCopy = g.Copy();
            List<Edge> path = new List<Edge>();
            Edge startEdge = selectRandomEdge(gCopy, startVertex);
            justRemovedEdge = startEdge;
            path.Add(startEdge);
            while (gCopy.numberOfVerticesRemaining() > 0)
            {
                    Edge chosenEdge = selectRandomEdge(gCopy, justRemovedEdge.vertexTwo());
                    if (chosenEdge != null)
                    {
                        path.Add(chosenEdge);
                        justRemovedEdge = chosenEdge;
                    }
                    else
                    {
                        //Redo if vertices remain untouched
                        return findRandomHamiltonianPath(g, startVertex);
                    }
            }

            return path;
        }
        public string GeneralAlgorithm(Graph g)
        {
            DateTime start = DateTime.Now;
            Graph gCopy = g.Copy();

            bool backTrack = false;

            List<Edge> path = new List<Edge>();
            Edge startEdge = selectShortestEdge(gCopy, 1);
            justRemovedEdge = startEdge;
            path.Add(startEdge);
            gCopy.removeEdges(gCopy.listEdges(1));
            gCopy.removeVertex(justRemovedEdge.vertexOne());
            gCopy.removeVertex(justRemovedEdge.vertexTwo());
            gCopy.removeEdge(startEdge);
            while (gCopy.numberOfVerticesRemaining() > 0)
            {
                Edge chosenEdge = null;
                if(!backTrack)
                {
                    chosenEdge = selectShortestEdge(gCopy, justRemovedEdge.vertexTwo());
                }
                else
                {
                    chosenEdge = firstBackTrackEdge(gCopy, path);
                    if (path.Count > 0)
                    {
                        justRemovedEdge = path[path.Count - 1];
                    }
                }

                if (chosenEdge != null)
                {
                    path.Add(chosenEdge);
                    gCopy.removeEdges(gCopy.listEdges(justRemovedEdge.vertexTwo()));
                    gCopy.removeVertex(chosenEdge.vertexOne());
                    gCopy.removeVertex(chosenEdge.vertexTwo());
                    gCopy.removeEdge(chosenEdge);
                    justRemovedEdge = chosenEdge;
                    backTrack = false;
                }
                else if (gCopy.numberOfVerticesRemaining() > 0)
                {
                    backTrack = true;
                }
            }
            DateTime stop = DateTime.Now;
            TimeSpan timeDiff = (stop - start);
            string outputString = String.Format("Time Taken: {0}:{1}:{2}:{3}\n", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds) + "Path: " + printEdges(path) + "\nDistance: " + pathDistance(path);
            return outputString;
        }


        //Methods whos primary purpose is to assist other methods
        public Edge firstBackTrackEdge(Graph g, List<Edge> path)
        {
            Edge lastMove = path[path.Count - 1];
            path.Remove(lastMove);
            g.addBackEdgeSet(lastMove);
            g.addBackOtherEdges(lastMove.vertexTwo(),lastMove, coveredVertices(path));
            g.addBackVertex(lastMove.vertexTwo());
            

            Edge chosenEdge = selectShortestEdge(g, lastMove.vertexOne());

            while (chosenEdge == null)
            {

                lastMove = path[path.Count - 1];
                path.Remove(lastMove);
                g.addBackEdgeSet(lastMove);
                
                g.addBackVertex(lastMove.vertexTwo());

                chosenEdge = selectShortestEdge(g, lastMove.vertexOne());

                g.addBackOtherEdges(lastMove.vertexTwo(), lastMove, coveredVertices(path));
                
            }

            return chosenEdge;
        }
        public Edge selectRandomEdge(Graph g, int vertex)
        {
            List<Edge> possibleEdges = g.listEdges(vertex);
            Random rand = new Random();
            if (possibleEdges.Count > 0)
            {               
                int r = rand.Next(0, possibleEdges.Count);
                Thread.Sleep(50);
                Edge chosenEdge = g.selectEdge(possibleEdges,r);
                return chosenEdge;
            }
            else
            {
                return null;
            }
        }
        public Edge selectShortestEdge(Graph g, int vertex)
        {
            List<Edge> edgeList = g.listEdges(vertex);
            if(edgeList.Count > 0)
            {
                int shortestLength = (int)edgeList.Min(e => e.getLength());
                Edge shortestEdge = edgeList.Where(e => e.getLength() == shortestLength).First();
                
                return shortestEdge;
            }

            return null;
        }        
        public void appendEulerCircuit(Graph g, List<Edge> eulerCircuit, int vertex)
        {         
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
        public int pathDistance(List<Edge> path)
        {
            int totalDist = 0;
            foreach (Edge e in path)
            {
                totalDist += e.getLength();
            }
            return totalDist;
        }

        public List<int> coveredVertices(List<Edge> path)
        {
            List<int> covered = new List<int>();
            foreach(Edge e in path)
            {
                covered.Add(e.vertexOne());
                covered.Add(e.vertexTwo());
            }
            List<int> distinctCovered = covered.Distinct().ToList();
            return distinctCovered;
        }
    }
}
