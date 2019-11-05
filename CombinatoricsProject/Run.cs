using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsProject
{
    class Run
    {
        static void Main(string[] args)
        {
            Algorithms a = new Algorithms();
            for (int i = 0; i < 4; i++)
            {
                DateTime start = DateTime.Now;
                //Graph g = testGraph();
                //a.Greedy(g);
                //a.Genetic(g);

                //Graph g1 = createGraphOne();
                //a.Greedy(g1);
                //string s = a.Genetic(g1);


                Graph g2 = createTypeFive();
                //a.Greedy(g2);
                string s = a.RandomHamiltonian(g2);


                //Graph g3 = createGraphThree();
                //a.Greedy(g3);

                DateTime stop = DateTime.Now;
                TimeSpan timeDiff = (stop - start);
                Console.WriteLine(String.Format("{0}:{1}:{2}:{3}", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds));
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        public static Graph testGraph()
        {
            //A square
            Graph testGraph = new Graph(4, new List<Edge>() { new Edge(1, 2, 10), new Edge(1, 4, 12), new Edge(2, 3, 10), new Edge(3, 4, 10) });
            return testGraph;
        }
        public static Graph createGraphOne()
        {
            //Solution is (1,4,2,8,5,7,11,12,7,3,12,5,11,6,8,9,2,6,5,4,10,1)
            //Graph is taken from WTT Test Archive 2017 Quiz 1 Problem 7
            Graph g = new Graph(12, new List<Edge>() {new Edge(1,4,10), new Edge(1,10,12),
                                                        new Edge(2,4,10), new Edge(2,6,10), new Edge(2,8,10), new Edge(2,9,10),
                                                        new Edge(3,7,10), new Edge(3,12,10),
                                                        new Edge(4,5,10), new Edge(4,10,10),
                                                        new Edge(5,6,10), new Edge(5,7,10), new Edge(5,8,10), new Edge(5,11,10), new Edge(5,12,10),
                                                        new Edge(6,8,10), new Edge(6,11,10),
                                                        new Edge(7,11,10),new Edge(7,12,10),
                                                        new Edge(8,9,10),
                                                        new Edge(11,12,10)});
            return g;
        }
        public static Graph createTypeFive()
        {
            Graph g = new Graph(38, new List<Edge>(){new Edge(1,2,10), new Edge(1,3,10),
                                                      new Edge(2,3,10), new Edge(2,9,10), new Edge(2,10,10),
                                                      new Edge(3,4,10), new Edge(3,8,10),
                                                      new Edge(4,5,10), new Edge(4,6,10), new Edge(4,7,10),
                                                      new Edge(5,6,10), new Edge(5,8,10), new Edge(5,15,10),
                                                      new Edge(6,7,10), new Edge(6,15,10),
                                                      new Edge(7,16,10), new Edge(7,17,10),
                                                      new Edge(8,10,10), new Edge(8,15,10),
                                                      new Edge(9,10,10), new Edge(9,11,10), new Edge(9,12,10),
                                                      new Edge(10,11,10), new Edge(10,14,10), new Edge(10,13,10),
                                                      new Edge(11,12,10), new Edge(11,21,10),
                                                      new Edge(12,21,10), new Edge(12,22,10), new Edge(12,23,10), new Edge(12,38,10),
                                                      new Edge(13,14,10), new Edge(13,18,10), new Edge(13,19,10), new Edge(13,20,10), new Edge(13,21,10),
                                                      new Edge(14,15,10), new Edge(14,18,10),
                                                      new Edge(15,16,10), new Edge(15,18,10),
                                                      new Edge(16,17,10), new Edge(16,18,10),
                                                      new Edge(17,27,10), new Edge(17,28,10),
                                                      new Edge(18,19,10), new Edge(18,26,10), new Edge(18,27,10), new Edge(18,30,10),
                                                      new Edge(19,20,10), new Edge(19,24,10), new Edge(19,25,10), new Edge(19,26,10),
                                                      new Edge(20,21,10), new Edge(20,24,10), new Edge(20,33,10), new Edge(20,35,10),
                                                      new Edge(21,23,10), new Edge(21,24,10), new Edge(21,35,10), new Edge(21,36,10),
                                                      new Edge(22,23,10),
                                                      new Edge(23,35,10), new Edge(23,36,10), new Edge(23,38,10),
                                                      new Edge(24,33,10), new Edge(24,34,10), new Edge(24,35,10),
                                                      new Edge(25,30,10), new Edge(25,31,10), new Edge(25,33,10),
                                                      new Edge(26,30,10), new Edge(26,31,10),
                                                      new Edge(27,28,10), new Edge(27,30,10),
                                                      new Edge(28,29,10), new Edge(28,30,10),
                                                      new Edge(29,30,10), new Edge(29,31,10), new Edge(29,32,10),
                                                      new Edge(30,31,10), new Edge(30,32,10),
                                                      new Edge(31,32,10), new Edge(31, 34, 10),
                                                      new Edge(32,33,10),
                                                      new Edge(33,34,10), new Edge(33,37,10),
                                                      new Edge(34,35,10), new Edge(34,36,10), new Edge(34, 37, 10),
                                                      new Edge(35,36,10),
                                                      new Edge(36,37,10), new Edge(36,38,10),
                                                      new Edge(37,38,10)});
            return g;
        }
        public static Graph createGraphThree()
        {
            Graph g = new Graph(13, new List<Edge>(){new Edge(1,2,10), new Edge(1,3,10), new Edge(1,4,10), new Edge(1,5,10),
                                                     new Edge(2,3,10), new Edge(2,5,10), new Edge(2,6,10), new Edge(2,8,10), new Edge(2,9,10),
                                                     new Edge(3,4,10), new Edge(3,5,10), new Edge(3,6,10), new Edge(3,7,10), new Edge(3,8,10), new Edge(3,9,10),
                                                     new Edge(4,6,10), new Edge(4,7,10), new Edge(4,9,10), new Edge(4,12,10),
                                                     new Edge(5,6,10), new Edge(5,8,10), new Edge(5,9,10),
                                                     new Edge(6,7,10), new Edge(6,8,10), new Edge(6,10,10), new Edge(6,11,10), new Edge(6,12,10), new Edge(6,13,10),
                                                     new Edge(7,8,10), new Edge(7,11,10), new Edge(7,13,10),
                                                     new Edge(8,9,10), new Edge(8,10,10), new Edge(8,11,10), new Edge(8,12,10), new Edge(8,13,10),
                                                     new Edge(9,10,10),
                                                     new Edge(10,11,10), new Edge(10,12,10), new Edge(10,13,10),
                                                     new Edge(11,12,10), new Edge(11,13,10),
                                                     new Edge(12,13,10) });
            return g;
        }
            
    }
}
