using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsProject
{
    class Run
    {
        static void Main(string[] args)
        {
            UI form = new UI();
            Application.EnableVisualStyles();
            Application.Run(form);

            //Algorithms a = new Algorithms();
            //Graph g = createOneHundred();
            //Console.WriteLine(a.Greedy(g));
            //Console.ReadLine();

            //Algorithms a = new Algorithms();
            //    for (int i = 0; i < 5; i++)
            //    {
            //        DateTime start = DateTime.Now;
            //        //Graph g = testGraph();

            //        //Graph g1 = createGraphOne();

            //Graph g = createTypeOneVOne();
            //        //Graph g = createTypeOneVTwo();

            //        //Graph g = createTypeTwoVOne();
            //        //Graph g = createTypeTwoVTwo();

            //        //Graph g = createTypeThreeVOne();
            //        //Graph g = createTypeThreeVTwo();

            //        //Graph g = createTypeFourVOne();
            //        //Graph g = createTypeFourVTwo();

            //        //Graph g = createTypeFiveVOne();
            //        //Graph g = createTypeFiveVTwo();

            //        //Graph g = createTypeSixVOne();
            //        //Graph g = createTypeSixVTwo();

            //        //Graph g = createTypeSevenVOne();
            //        //Graph g = createTypeSevenVTwo();

            //        //Graph g = createTypeEightVOne();
            //        //Graph g = createTypeEightVTwo();

            //        //Graph g = createTypeNineVOne();
            //        Graph g = createTypeNineVTwo();

            //        //Graph g = completeFiveVertex();
            //        //Graph g = createOneHundred();

            //string s = a.Greedy(g);
            //        //string s = a.RandomHamiltonian(g);
            //        string s = a.GeneralAlgorithm(g);
            //        DateTime stop = DateTime.Now;
            //        TimeSpan timeDiff = (stop - start);
            //        Console.WriteLine(String.Format("Time Taken: {0}:{1}:{2}:{3}", timeDiff.Days, timeDiff.Hours, timeDiff.Minutes, timeDiff.Seconds));
            //Console.WriteLine(s);

            //    //start = DateTime.Now;
            //    //Graph g1 = createTypeFiveVTwo();
            //    //s = a.GeneralAlgorithm(g1);
            //    //stop = DateTime.Now;
            //    //TimeSpan timeDiff1 = (stop - start);
            //    //Console.WriteLine(String.Format("T5V2\nTime Taken: {0}:{1}:{2}:{3}", timeDiff1.Days, timeDiff1.Hours, timeDiff1.Minutes, timeDiff1.Seconds));
            //    //Console.WriteLine(s);

            //    //start = DateTime.Now;
            //    //Graph g2 = createTypeSixVOne();
            //    //s = a.GeneralAlgorithm(g2);
            //    //stop = DateTime.Now;
            //    //TimeSpan timeDiff2 = (stop - start);
            //    //Console.WriteLine(String.Format("T6V1\nTime Taken: {0}:{1}:{2}:{3}", timeDiff2.Days, timeDiff2.Hours, timeDiff2.Minutes, timeDiff2.Seconds));
            //    //Console.WriteLine(s);

            //    //start = DateTime.Now;
            //    //Graph g3 = createTypeSixVTwo();
            //    //s = a.GeneralAlgorithm(g3);
            //    //stop = DateTime.Now;
            //    //TimeSpan timeDiff3 = (stop - start);
            //    //Console.WriteLine(String.Format("T6V2\nTime Taken: {0}:{1}:{2}:{3}", timeDiff3.Days, timeDiff3.Hours, timeDiff3.Minutes, timeDiff3.Seconds));
            //    //Console.WriteLine(s);

            //    //start = DateTime.Now;
            //    //Graph g4 = createTypeNineVOne();
            //    //s = a.GeneralAlgorithm(g4);
            //    //stop = DateTime.Now;
            //    //TimeSpan timeDiff4 = (stop - start);
            //    //Console.WriteLine(String.Format("T9V1\nTime Taken: {0}:{1}:{2}:{3}", timeDiff4.Days, timeDiff4.Hours, timeDiff4.Minutes, timeDiff4.Seconds));
            //    //Console.WriteLine(s);

            //    //start = DateTime.Now;
            //    //Graph g5 = createTypeNineVTwo();
            //    //s = a.GeneralAlgorithm(g5);
            //    //stop = DateTime.Now;
            //    //TimeSpan timeDiff5 = (stop - start);
            //    //Console.WriteLine(String.Format("T9V2\nTime Taken: {0}:{1}:{2}:{3}", timeDiff5.Days, timeDiff5.Hours, timeDiff5.Minutes, timeDiff5.Seconds));
            //    //Console.WriteLine(s);
            //}
            //Console.ReadLine();
        }

        private static Graph createTypeOneVOne()
        {
            Graph g = new Graph(18, new List<Edge>() { new Edge(1, 2,19 ), new Edge(1, 3, 15), new Edge(1, 4, 7), new Edge(1, 17, 21),
                                                        new Edge(2, 3, 13), new Edge(2, 17, 8), new Edge(2, 18, 26),
                                                        new Edge(3, 4, 22), new Edge(3, 19, 18),
                                                        new Edge(4, 5, 11), new Edge(4, 19, 10),
                                                        new Edge(5, 6, 14),
                                                        new Edge(6, 7, 23),
                                                        new Edge(7, 8, 30),
                                                        new Edge(8, 9, 7),
                                                        new Edge(9, 10, 14),
                                                        new Edge(10, 11, 26),
                                                        new Edge(11, 12, 9),
                                                        new Edge(12, 13, 30),
                                                        new Edge(13, 14, 16),
                                                        new Edge(14, 15, 8),
                                                        new Edge(15, 16, 24),
                                                        new Edge(16, 17, 12),
                                                        new Edge(17, 18, 21)});
            return g;
        }
        private static Graph createOneHundred()
        {
            Graph g = new Graph(100, new List<Edge>() { new Edge(1, 2, 9), new Edge(1, 3, 5), new Edge(1, 5, 5), new Edge(1, 7, 29),
                                                        new Edge(2, 3, 16), new Edge(2, 4, 21), new Edge(2, 7, 14), new Edge(2, 8, 14), new Edge(2, 9, 2),
                                                        new Edge(3, 4, 30), new Edge(3, 5, 29), new Edge(3, 6, 25), new Edge(3, 7, 4), new Edge(3, 8, 18), new Edge(3, 10, 1),
                                                        new Edge(4, 5, 17), new Edge(4, 6, 28), new Edge(4, 7, 23), new Edge(4, 10, 13),
                                                        new Edge(5, 6, 12), new Edge(5, 7, 11), new Edge(5, 12, 27), new Edge(5, 13, 7), new Edge(5, 14, 2),
                                                        new Edge(6, 7, 3), new Edge(6, 10, 19), new Edge(6, 11, 16), new Edge(6, 12, 9), new Edge(6, 13, 17), new Edge(6, 14, 29), new Edge(6, 26, 20), new Edge(6, 27, 8), new Edge(6, 28, 6),
                                                        new Edge(7, 8, 16), new Edge(7, 9, 12), new Edge(7, 10, 15), new Edge(7, 11, 18),
                                                        new Edge(8, 9, 8), new Edge(8, 92, 23), new Edge(8, 97, 21), new Edge(8, 98, 11), new Edge(8, 99, 10),
                                                        new Edge(9, 10, 12), new Edge(9, 11, 20), new Edge(9, 28, 17), new Edge(9, 92, 28), new Edge(9, 93, 9), new Edge(9, 97, 13), new Edge(9, 98, 13),
                                                        new Edge(10, 11, 25), new Edge(10, 12, 30), new Edge(10, 14, 17),
                                                        new Edge(11, 12, 16), new Edge(11, 23, 30), new Edge(11, 24, 18), new Edge(11, 28, 28),
                                                        new Edge(12, 13, 13), new Edge(12, 14, 26), new Edge(12, 25, 24), new Edge(12, 26, 9), new Edge(12, 27, 19), new Edge(12, 28, 14),
                                                        new Edge(13, 14, 8), new Edge(13, 23, 21), new Edge(13, 24, 25), new Edge(13, 25, 27), new Edge(13, 26, 5),
                                                        new Edge(14, 15, 14), new Edge(14, 22, 12), new Edge(14, 23, 7), new Edge(14, 24, 7), new Edge(14, 25, 6), new Edge(14, 26, 7), new Edge(14, 31, 10),
                                                        new Edge(15, 16, 24), new Edge(15, 17, 8), new Edge(15, 18, 14), new Edge(15, 19, 16), new Edge(15, 20, 9), new Edge(15, 21, 21), new Edge(15, 22, 19),
                                                        new Edge(16, 17, 18), new Edge(16, 18, 30), new Edge(16, 19, 28), new Edge(16, 20, 11), new Edge(16, 21, 23), new Edge(16, 22, 8), new Edge(16, 23, 20),
                                                        new Edge(17, 18, 29), new Edge(17, 19, 26), new Edge(17, 20, 11), new Edge(17, 21, 24), new Edge(17, 22, 5), new Edge(17, 23, 20),
                                                        new Edge(18, 19, 12), new Edge(18, 20, 30), new Edge(18, 21, 6), new Edge(18, 22, 18), new Edge(18, 35, 19),
                                                        new Edge(19, 20, 24), new Edge(19, 21, 16), new Edge(19, 22, 23), new Edge(19, 36, 30),
                                                        new Edge(20, 21, 23), new Edge(20, 22, 5), new Edge(20, 36, 13),
                                                        new Edge(21, 22, 22), new Edge(21, 35, 17),
                                                        new Edge(23, 24, 27), new Edge(23, 25, 26), new Edge(23, 31, 20),
                                                        new Edge(24, 25, 14), new Edge(24, 31, 20), new Edge(24, 32, 22), new Edge(24, 33, 23), new Edge(24, 34, 6), new Edge(24, 35, 29),
                                                        new Edge(25, 26, 30), new Edge(25, 27, 5), new Edge(25, 28, 28), new Edge(25, 29, 14), new Edge(25, 30, 15), new Edge(25, 31, 12), new Edge(25, 65, 20),
                                                        new Edge(26, 27, 17), new Edge(26, 28, 17), new Edge(26, 29, 13), new Edge(26, 30, 12), new Edge(26, 31, 26),
                                                        new Edge(27, 28, 30), new Edge(27, 29, 29), new Edge(27, 30, 9), new Edge(27, 31, 21),
                                                        new Edge(28, 29, 26), new Edge(28, 30, 21), new Edge(28, 31, 11), new Edge(28, 65, 13), new Edge(28, 66, 11), new Edge(28, 67, 18), new Edge(28, 68, 18), new Edge(28, 91, 18), new Edge(28, 92, 26), new Edge(28, 93, 13), new Edge(28, 98, 25),
                                                        new Edge(29, 30, 18), new Edge(29, 31, 25), new Edge(29, 32, 29), new Edge(29, 53, 30), new Edge(29, 55, 7), new Edge(29, 56, 5), new Edge(29, 65, 18), new Edge(29, 66, 18), new Edge(29, 67, 22), new Edge(29, 68, 8), new Edge(29, 92, 15), new Edge(29, 99, 28),
                                                        new Edge(30, 31, 23), new Edge(30, 32, 17), new Edge(30, 33, 6), new Edge(30, 55, 17), new Edge(30, 56, 20), new Edge(30, 65, 17), new Edge(30, 89, 14),
                                                        new Edge(31, 32, 27), new Edge(31, 33, 20), new Edge(31, 34, 16), new Edge(31, 35, 21), new Edge(31, 51, 10),
                                                        new Edge(32, 33, 27), new Edge(32, 51, 6), new Edge(32, 52, 21), new Edge(32, 53, 16), new Edge(32, 54, 18), new Edge(32, 67, 26),
                                                        new Edge(33, 34, 8), new Edge(33, 42, 12), new Edge(33, 51, 5), new Edge(33, 52, 28), new Edge(33, 53, 18), new Edge(33, 54, 6),
                                                        new Edge(34, 35, 26), new Edge(34, 36, 28), new Edge(34, 37, 12), new Edge(34, 38, 15), new Edge(34, 39, 21), new Edge(34, 40, 11), new Edge(34, 41, 24), new Edge(34, 42, 26), new Edge(34, 51, 22),
                                                        new Edge(35, 36, 29), new Edge(35, 37, 28), new Edge(35, 38, 18), new Edge(35, 39, 19), new Edge(35, 40, 8), new Edge(35, 41, 27), new Edge(35, 42, 15),
                                                        new Edge(36, 37, 19), new Edge(36, 38, 20), new Edge(36, 39, 19), new Edge(36, 40, 13), new Edge(36, 41, 12), new Edge(36, 42, 28),
                                                        new Edge(37, 38, 9), new Edge(37, 39, 9), new Edge(37, 40, 8), new Edge(37, 41, 26), new Edge(37, 42, 6),
                                                        new Edge(38, 39, 18), new Edge(38, 40, 7), new Edge(38, 41, 22), new Edge(38, 42, 28), new Edge(38, 46, 25), new Edge(38, 47, 25),
                                                        new Edge(39, 40, 27), new Edge(39, 41, 5), new Edge(39, 42, 26), new Edge(39, 46, 15), new Edge(39, 47, 20),
                                                        new Edge(40, 41, 18), new Edge(40, 42, 14), new Edge(40, 45, 26), new Edge(40, 46, 17),
                                                        new Edge(41, 42, 14),
                                                        new Edge(42, 43, 25), new Edge(42, 44, 6), new Edge(42, 51, 26),
                                                        new Edge(43, 44, 28), new Edge(43, 45, 7), new Edge(43, 46, 27), new Edge(43, 47, 11), new Edge(43, 48, 21), new Edge(43, 49, 14), new Edge(43, 50, 13),
                                                        new Edge(44, 45, 14), new Edge(44, 46, 13), new Edge(44, 47, 7), new Edge(44, 48, 16), new Edge(44, 49, 17), new Edge(44, 50, 14),
                                                        new Edge(45, 46, 5), new Edge(45, 47, 25), new Edge(45, 48, 18), new Edge(45, 49, 28), new Edge(45, 50, 17),
                                                        new Edge(46, 47, 8), new Edge(46, 48, 25), new Edge(46, 49, 5), new Edge(46, 50, 9),
                                                        new Edge(47, 48, 5), new Edge(47, 49, 30), new Edge(47, 50, 26), new Edge(47, 55, 18),
                                                        new Edge(48, 49, 23), new Edge(48, 50, 14), new Edge(48, 55, 15),
                                                        new Edge(49, 50, 24), new Edge(49, 51, 13),
                                                        new Edge(50, 51, 18),
                                                        new Edge(51, 52, 23), new Edge(51, 53, 12), new Edge(51, 54, 18), new Edge(51, 55, 9), new Edge(51, 56, 20),
                                                        new Edge(52, 53, 16), new Edge(52, 54, 15), new Edge(52, 55, 12), new Edge(52, 56, 6), new Edge(52, 65, 7),
                                                        new Edge(53, 54, 25), new Edge(53, 65, 18), new Edge(53, 67, 11),
                                                        new Edge(54, 65, 30),
                                                        new Edge(55, 56, 22), new Edge(55, 65, 18),
                                                        new Edge(56, 57, 23), new Edge(56, 61, 13), new Edge(56, 62, 14), new Edge(56, 64, 20), new Edge(56, 65, 10),
                                                        new Edge(57, 58, 17), new Edge(57, 59, 28), new Edge(57, 60, 21), new Edge(57, 61, 6), new Edge(57, 62, 17),
                                                        new Edge(58, 59, 26), new Edge(58, 60, 8), new Edge(58, 61, 22), new Edge(58, 62, 23), new Edge(58, 71, 30),
                                                        new Edge(59, 60, 30), new Edge(59, 61, 25), new Edge(59, 62, 27), new Edge(59, 71, 8),
                                                        new Edge(60, 61, 17), new Edge(60, 62, 8), new Edge(60, 63, 14), new Edge(60, 64, 18), new Edge(60, 71, 11),
                                                        new Edge(61, 62, 13),
                                                        new Edge(62, 63, 19), new Edge(62, 71, 11),
                                                        new Edge(63, 64, 14), new Edge(63, 65, 23), new Edge(63, 66, 24), new Edge(63, 67, 18), new Edge(63, 68, 20), new Edge(63, 69, 24), new Edge(63, 70, 19), new Edge(63, 71, 6),
                                                        new Edge(64, 65, 29), new Edge(64, 66, 14), new Edge(64, 67, 22), new Edge(64, 68, 19), new Edge(64, 69, 14), new Edge(64, 70, 20), new Edge(64, 71, 16),
                                                        new Edge(65, 66, 27), new Edge(65, 67, 21), new Edge(65, 68, 16), new Edge(65, 69, 12), new Edge(65, 70, 25), new Edge(65, 71, 27), new Edge(65, 89, 5),
                                                        new Edge(66, 67, 25), new Edge(66, 68, 29), new Edge(66, 69, 5), new Edge(66, 70, 27), new Edge(66, 71, 20),
                                                        new Edge(67, 68, 23), new Edge(67, 69, 5), new Edge(67, 70, 9), new Edge(67, 71, 30),
                                                        new Edge(68, 69, 14), new Edge(68, 70, 5), new Edge(68, 71, 12), new Edge(68, 91, 27), new Edge(68, 92, 17),
                                                        new Edge(69, 70, 11), new Edge(69, 71, 19), new Edge(69, 91, 22), new Edge(69, 92, 25),
                                                        new Edge(70, 71, 27), new Edge(70, 78, 23), new Edge(70, 79, 8), new Edge(70, 88, 7), new Edge(70, 90, 26),
                                                        new Edge(71, 72, 15), new Edge(71, 73, 18), new Edge(71, 79, 22), new Edge(71, 89, 10),
                                                        new Edge(72, 73, 25), new Edge(72, 74, 25), new Edge(72, 75, 7), new Edge(72, 76, 26), new Edge(72, 77, 9), new Edge(72, 78, 27), new Edge(72, 79, 10),
                                                        new Edge(73, 74, 6), new Edge(73, 75, 21), new Edge(73, 76, 13), new Edge(73, 77, 8), new Edge(73, 78, 25), new Edge(73, 79, 10),
                                                        new Edge(74, 75, 24), new Edge(74, 76, 12), new Edge(74, 77, 18), new Edge(74, 78, 6), new Edge(74, 79, 9), new Edge(74, 81, 29),
                                                        new Edge(75, 76, 30), new Edge(75, 77, 6), new Edge(75, 78, 15), new Edge(75, 79, 24), new Edge(75, 81, 18),
                                                        new Edge(76, 77, 28), new Edge(76, 78, 18), new Edge(76, 79, 11), new Edge(76, 89, 12),
                                                        new Edge(77, 78, 30), new Edge(77, 79, 23), new Edge(77, 89, 22),
                                                        new Edge(78, 79, 28),
                                                        new Edge(79, 89, 19),
                                                        new Edge(80, 81, 8), new Edge(80, 82, 25), new Edge(80, 83, 7), new Edge(80, 84, 8), new Edge(80, 85, 11), new Edge(80, 86, 25), new Edge(80, 87, 5), new Edge(80, 89, 9),
                                                        new Edge(81, 82, 27), new Edge(81, 83, 13), new Edge(81, 84, 15), new Edge(81, 85, 13), new Edge(81, 86, 29), new Edge(81, 87, 10), new Edge(81, 89, 40),
                                                        new Edge(82, 83, 16), new Edge(82, 84, 29), new Edge(82, 85, 24), new Edge(82, 86, 24), new Edge(82, 87, 15), new Edge(82, 97, 8),
                                                        new Edge(83, 84, 7), new Edge(83, 85, 7), new Edge(83, 86, 22), new Edge(83, 87, 27), new Edge(83, 97, 26),
                                                        new Edge(84, 85, 14), new Edge(84, 86, 24), new Edge(84, 87, 8), new Edge(84, 96, 12),
                                                        new Edge(85, 86, 14), new Edge(85, 87, 17), new Edge(85, 96, 23),
                                                        new Edge(86, 87, 13), new Edge(86, 88, 23),
                                                        new Edge(87, 88, 9),
                                                        new Edge(88, 89, 14), new Edge(88, 90, 18), new Edge(88, 91, 6), new Edge(88, 93, 22), new Edge(88, 94, 24), new Edge(88, 95, 11), new Edge(88, 96, 17),
                                                        new Edge(89, 90, 28),
                                                        new Edge(90, 91, 6), new Edge(90, 93, 30), new Edge(90, 94, 19),
                                                        new Edge(91, 92, 16), new Edge(91, 93, 26), new Edge(91, 94, 26),
                                                        new Edge(92, 93, 26), new Edge(92, 94, 17), new Edge(92, 95, 10),
                                                        new Edge(93, 94, 9), new Edge(93, 95, 9), new Edge(93, 98, 5), new Edge(93, 100, 17),
                                                        new Edge(94, 95, 19), new Edge(94, 96, 8), new Edge(94, 100, 26),
                                                        new Edge(95, 96, 11), new Edge(95, 97, 16), new Edge(95, 98, 14), new Edge(95, 100, 13),
                                                        new Edge(96, 97, 20), new Edge(96, 99, 30), new Edge(96, 100, 21),
                                                        new Edge(97, 98, 7), new Edge(97, 99, 5),
                                                        new Edge(98, 99, 14), new Edge(98, 100, 9),
                                                        new Edge(99, 100, 15)});
            return g;
        }
    } 
}
