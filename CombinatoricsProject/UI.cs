using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CombinatoricsProject.Properties;

namespace CombinatoricsProject
{
    public partial class UI : Form
    {
        public int type = 0;
        public int version = 0;
        private List<List<Graph>> graphs;
        private List<List<Image>> images;
        private Graph selectedGraph;
        private Algorithms a;

        public UI()
        {
            InitializeComponent();
            a = new Algorithms();
        }

        public void updateForm()
        {
            if (typeBox.SelectedItem != null)
            {
                type = int.Parse(typeBox.SelectedItem.ToString());
            }
            if (versionBox.SelectedItem != null)
            {
                version = int.Parse(versionBox.SelectedItem.ToString()); ;
            }
            if (typeBox.SelectedItem != null && versionBox.SelectedItem != null)
            {
                images = setImages();
                imageBox.Image = images[type - 1][version - 1];
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Euler Button
            if (everythingSatisfied())
            {
                graphs = setGraphs();
                selectedGraph = graphs[type - 1][version - 1];
                string output = a.Greedy(selectedGraph);
                outputLabel.Text = output;
            }           
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            if (everythingSatisfied())
            {
                graphs = setGraphs();
                selectedGraph = graphs[type - 1][version - 1];
                string output = a.RandomHamiltonian(selectedGraph);
                outputLabel.Text = output;
            }
        }

        private void generalButton_Click(object sender, EventArgs e)
        {
            if (everythingSatisfied())
            {
                graphs = setGraphs();
                selectedGraph = graphs[type - 1][version - 1];
                string output = a.GeneralAlgorithm(selectedGraph);
                outputLabel.Text = output;
            }
        }

        public void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private void versionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateForm();
        }

        private List<List<Graph>> setGraphs()
        {
            List<List<Graph>> graphList = new List<List<Graph>>() {
                new List<Graph>(){createTypeOneVOne(), createTypeOneVTwo()},
                new List<Graph>(){createTypeTwoVOne(), createTypeTwoVTwo()},
                new List<Graph>(){createTypeThreeVOne(), createTypeThreeVTwo()},
                new List<Graph>(){createTypeFourVOne(), createTypeFourVTwo()},
                new List<Graph>(){createTypeFiveVOne(), createTypeFiveVTwo()},
                new List<Graph>(){createTypeSixVOne(), createTypeSixVTwo()},
                new List<Graph>(){createTypeSevenVOne(), createTypeSevenVTwo()},
                new List<Graph>(){createTypeEightVOne(), createTypeEightVTwo()},
                new List<Graph>(){createTypeNineVOne(), createTypeNineVTwo()},
                new List<Graph>(){completeFiveVertex(), createOneHundred()}
            };
            return graphList;
        }
        private List<List<Image>> setImages()
        {
            List<List<Image>> imageList = new List<List<Image>>() {
                new List<Image>(){Resources.Type1Version1, Resources.Type1Version2},
                new List<Image>(){Resources.Type2Version1, Resources.Type2Version2},
                new List<Image>(){Resources.Type3Version1, Resources.Type3Version2},
                new List<Image>(){Resources.Type4Version1, Resources.Type4Version2},
                new List<Image>(){Resources.Type5Version1, Resources.Type5Version2},
                new List<Image>(){Resources.Type6Version1, Resources.Type6Version2},
                new List<Image>(){Resources.Type7Version1, Resources.Type7Version2},
                new List<Image>(){Resources.Type8Version1, Resources.Type8Version2},
                new List<Image>(){Resources.Type9Version1,Resources.Type9Version2},
                new List<Image>(){Resources.Type10Verison1, Resources.Type10Version2}
            };
            return imageList;
        }
        private bool everythingSatisfied()
        {
            if (type == 0)
            {
                outputLabel.Text = "Select a graph type";
                return false;
            }
            else if (version == 0)
            {
                outputLabel.Text = "Select a graph version";
                return false;
            }
            return true;
        }

        private static Graph testGraph()
        {
            //A square
            Graph testGraph = new Graph(4, new List<Edge>() { new Edge(1, 2, 10), new Edge(1, 4, 12), new Edge(2, 3, 10), new Edge(3, 4, 10) });
            return testGraph;
        }
        private static Graph createGraphOne()
        {
            //Solution is (1,4,2,8,5,7,11,12,7,3,12,5,11,6,8,9,2,6,5,4,10,1)
            //Graph is taken from WTT Test Archive 2017 Quiz 1 Problem 7
            Graph g = new Graph(12, new List<Edge>() {new Edge(1,4,10), new Edge(1,10,10),
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
        private static Graph createTypeOneVTwo()
        {
            Graph g = new Graph(12, new List<Edge>() { new Edge(1, 2, 8), new Edge(1, 10, 13),
                                                        new Edge(2, 3, 16), new Edge(2, 11, 11), new Edge(2, 12, 29),
                                                        new Edge(3, 4, 19), new Edge(3, 11, 12), new Edge(3, 12, 16),
                                                        new Edge(4, 5, 24),
                                                        new Edge(5, 6, 27),
                                                        new Edge(6, 7, 14),
                                                        new Edge(7, 8, 20),
                                                        new Edge(8, 9, 9),
                                                        new Edge(9, 10, 5),
                                                        new Edge(10, 11, 30), new Edge(10, 12, 22),
                                                        new Edge(11, 12, 14)});
            return g;
        }

        private static Graph createTypeTwoVOne()
        {
            Graph g = new Graph(21, new List<Edge>() { new Edge(1, 2, 26), new Edge(1, 21, 14),
                                                        new Edge(2, 3, 10), new Edge(2, 14, 18), new Edge(2, 21, 6),
                                                        new Edge(3, 4, 29),
                                                        new Edge(4, 5, 13),
                                                        new Edge(5, 6, 17),
                                                        new Edge(6, 7, 19),
                                                        new Edge(7, 8, 12),
                                                        new Edge(8, 9, 30),
                                                        new Edge(9, 10, 23),
                                                        new Edge(10, 11, 28),
                                                        new Edge(11, 12, 14),
                                                        new Edge(12, 13, 18),
                                                        new Edge(13, 14, 9),
                                                        new Edge(14, 15, 20), new Edge(14, 21, 13),
                                                        new Edge(15, 16, 18),
                                                        new Edge(16, 17, 22),
                                                        new Edge(17, 18, 11),
                                                        new Edge(18, 19, 15),
                                                        new Edge(19, 20, 7),
                                                        new Edge(20, 21, 23)});
            return g;
        }
        private static Graph createTypeTwoVTwo()
        {
            Graph g = new Graph(30, new List<Edge>() { new Edge(1, 2, 19), new Edge(1, 16, 30),
                                                        new Edge(2, 30, 30),
                                                        new Edge(3, 4, 12), new Edge(3, 14, 9), new Edge(3, 23, 15),new Edge(3, 30, 14),
                                                        new Edge(4, 13, 6), new Edge(4, 23, 16), new Edge(4, 30, 5),
                                                        new Edge(5, 6, 10), new Edge(5, 12, 22),
                                                        new Edge(6, 7, 12),
                                                        new Edge(7, 10, 8),
                                                        new Edge(8, 9, 14), new Edge(8, 10, 19), new Edge(8, 11, 27), new Edge(8, 25, 20),
                                                        new Edge(9, 10, 26), new Edge(9, 24, 20), new Edge(9, 25, 26),
                                                        new Edge(10, 23, 23),
                                                        new Edge(11, 12, 22),
                                                        new Edge(12, 13, 9), new Edge(12, 21, 25),
                                                        new Edge(13, 14, 25), new Edge(13, 21, 25),
                                                        new Edge(14, 15, 19), new Edge(14, 19, 15),
                                                        new Edge(15, 16, 17), new Edge(15, 19, 14), new Edge(15, 29, 24),
                                                        new Edge(16, 17, 7), new Edge(16, 18, 18),
                                                        new Edge(17, 18, 14), new Edge(17, 19, 7), new Edge(17, 20, 19),
                                                        new Edge(18, 20, 9), new Edge(18, 29, 16),
                                                        new Edge(19, 29, 20),
                                                        new Edge(20, 21, 24), new Edge(20, 28, 14),
                                                        new Edge(21, 27, 6),
                                                        new Edge(22, 23, 24), new Edge(22, 25, 28), new Edge(22, 26, 21), new Edge(22, 27, 15),
                                                        new Edge(24, 25, 9),
                                                        new Edge(25, 26, 6), new Edge(25, 27, 20),
                                                        new Edge(27, 28, 29),
                                                        new Edge(29, 30, 18)});
            return g;
        }

        private static Graph createTypeThreeVOne()
        {
            Graph g = new Graph(43, new List<Edge>(){new Edge(1, 2, 18), new Edge(1, 41, 13), new Edge(1, 42, 24), new Edge(1, 43, 7),
                                                        new Edge(2, 3, 17),
                                                        new Edge(3, 4, 5),
                                                        new Edge(4, 5, 25),
                                                        new Edge(5, 6, 23),
                                                        new Edge(6, 7, 30),
                                                        new Edge(7, 8, 27),
                                                        new Edge(8, 9, 29),
                                                        new Edge(9, 10, 11),
                                                        new Edge(10, 11, 24),
                                                        new Edge(11, 12, 11),
                                                        new Edge(12, 13, 14),
                                                        new Edge(13, 14, 6),
                                                        new Edge(14, 15, 10),
                                                        new Edge(15, 16, 10),
                                                        new Edge(16, 17, 23),
                                                        new Edge(17, 18, 20),
                                                        new Edge(18, 19, 7),
                                                        new Edge(19, 20, 12),
                                                        new Edge(20, 21, 19),
                                                        new Edge(21, 22, 12), new Edge(21, 42, 5), new Edge(21, 43, 24),
                                                        new Edge(22, 23, 25),
                                                        new Edge(23, 24, 8),
                                                        new Edge(24, 25, 30),
                                                        new Edge(25, 26, 24),
                                                        new Edge(26, 27, 21),
                                                        new Edge(27, 28, 26),
                                                        new Edge(28, 29, 19),
                                                        new Edge(29, 30, 20),
                                                        new Edge(30, 31, 20),
                                                        new Edge(31, 32, 7),
                                                        new Edge(32, 33, 15),
                                                        new Edge(33, 34, 5),
                                                        new Edge(34, 35, 23),
                                                        new Edge(35, 36, 20),
                                                        new Edge(36, 37, 27),
                                                        new Edge(37, 38, 7),
                                                        new Edge(38, 39, 28),
                                                        new Edge(39, 40, 11),
                                                        new Edge(40, 41, 28),
                                                        new Edge(41, 42, 24), new Edge(41, 43, 21),
                                                        new Edge(42, 43, 11)});
            return g;
        }
        private static Graph createTypeThreeVTwo()
        {
            Graph g = new Graph(40, new List<Edge>() { new Edge(1, 2, 10), new Edge(1, 40, 5),
                                                        new Edge(2, 3, 20),
                                                        new Edge(3, 4, 6),
                                                        new Edge(4, 5, 15),
                                                        new Edge(5, 6, 23),
                                                        new Edge(6, 7, 15),
                                                        new Edge(7, 8, 14), new Edge(7, 11, 13), new Edge(7, 14, 28),
                                                        new Edge(8, 9, 10),
                                                        new Edge(9, 10, 6),
                                                        new Edge(10, 11, 20), new Edge(10, 14, 22), new Edge(10, 20, 24),
                                                        new Edge(11, 12, 30), new Edge(11, 20, 14),
                                                        new Edge(12, 13, 9),
                                                        new Edge(13, 14, 26),
                                                        new Edge(14, 15, 7),
                                                        new Edge(15, 16, 22),
                                                        new Edge(16, 17, 23),
                                                        new Edge(17, 18, 12), new Edge(17, 21, 30), new Edge(17, 24, 25),
                                                        new Edge(18, 19, 27),
                                                        new Edge(19, 20, 5),
                                                        new Edge(20, 21, 12), new Edge(20, 24, 25), new Edge(20, 30, 15),
                                                        new Edge(21, 22, 14), new Edge(21, 30, 19),
                                                        new Edge(22, 23, 6),
                                                        new Edge(23, 24, 22),
                                                        new Edge(24, 25, 24),
                                                        new Edge(25, 26, 7),
                                                        new Edge(26, 27, 30),
                                                        new Edge(27, 28, 15), new Edge(27, 31, 27), new Edge(27, 34, 20),
                                                        new Edge(28, 29, 27),
                                                        new Edge(29, 30, 18),
                                                        new Edge(30, 31, 15), new Edge(30, 34, 14), new Edge(30, 40, 31),
                                                        new Edge(31, 32, 6), new Edge(31, 40, 19),
                                                        new Edge(32, 33, 24),
                                                        new Edge(33, 34, 27),
                                                        new Edge(34, 35, 20),
                                                        new Edge(35, 36, 27),
                                                        new Edge(36, 37, 25),
                                                        new Edge(37, 38, 18),
                                                        new Edge(38, 39, 5),
                                                        new Edge(39, 40, 8)});
            return g;
        }

        private static Graph createTypeFourVOne()
        {
            Graph g = new Graph(17, new List<Edge>() { new Edge(1, 2, 10), new Edge(1, 3, 10), new Edge(1, 14, 10), new Edge(1, 15, 10), new Edge(1, 16, 10), new Edge(1, 17, 10),
                                                        new Edge(2, 3, 10), new Edge(2, 4, 10), new Edge(2, 5, 10), new Edge(2, 16, 10), new Edge(2, 17, 10),
                                                        new Edge(3, 4, 10), new Edge(3, 5, 10),
                                                        new Edge(4, 5, 10), new Edge(4, 6, 10), new Edge(4, 7, 10), new Edge(4, 17, 10),
                                                        new Edge(5, 6, 10), new Edge(5, 10, 112), new Edge(5, 11, 124), new Edge(5, 14, 10), new Edge(5, 15, 10), new Edge(5, 16, 10), new Edge(5, 17, 10),
                                                        new Edge(6, 7, 10), new Edge(6, 8, 10), new Edge(6, 9, 10), new Edge(6, 15, 10),
                                                        new Edge(7, 8, 10), new Edge(7, 10, 10), new Edge(7, 11, 10), new Edge(7, 12, 10), new Edge(7, 15, 10), new Edge(7, 16, 10),
                                                        new Edge(8, 9, 10), new Edge(8, 10, 10),
                                                        new Edge(9, 10, 10), new Edge(9, 11, 10),
                                                        new Edge(10, 11, 10), new Edge(10, 12, 10), new Edge(10, 13, 10), new Edge(10, 15, 10),
                                                        new Edge(11, 12, 10), new Edge(11, 13, 10),
                                                        new Edge(12, 13, 10), new Edge(12, 14, 10), new Edge(12, 15, 10),
                                                        new Edge(13, 14, 10),
                                                        new Edge(14, 15, 10), new Edge(14, 16, 10),
                                                        new Edge(15, 16, 10),
                                                        new Edge(16, 17, 10)});
            return g;
        }
        private static Graph createTypeFourVTwo()
        {
            //Creates the second Type Four graph
            Graph g = new Graph(13, new List<Edge>() { new Edge(1, 2, 4), new Edge(1, 3, 5), new Edge(1, 4, 7), new Edge(1, 5, 10),
                                                        new Edge(2, 3, 11), new Edge(2, 5, 14), new Edge(2, 6, 12), new Edge(2, 8, 8), new Edge(2, 9, 14),
                                                        new Edge(3, 4, 15), new Edge(3, 5, 3), new Edge(3, 6, 18), new Edge(3, 7, 9), new Edge(3, 8, 8), new Edge(3, 9, 7),
                                                        new Edge(4, 6, 10), new Edge(4, 7, 13), new Edge(4, 9, 12), new Edge(4, 12, 6),
                                                        new Edge(5, 6, 11), new Edge(5, 8, 10), new Edge(5, 9, 9),
                                                        new Edge(6, 7, 12), new Edge(6, 8, 17), new Edge(6, 10, 6), new Edge(6, 11, 5), new Edge(6, 12, 4), new Edge(6, 13, 10),
                                                        new Edge(7, 8, 4), new Edge(7, 11, 12), new Edge(7, 13, 15),
                                                        new Edge(8, 9, 19), new Edge(8, 10, 3), new Edge(8, 11, 11), new Edge(8, 12, 10), new Edge(8, 13, 15),
                                                        new Edge(9, 10, 10),
                                                        new Edge(10, 11, 3), new Edge(10, 12, 6), new Edge(10, 13, 4),
                                                        new Edge(11, 12, 6), new Edge(11, 13, 9),
                                                        new Edge(12, 13, 17)});
            return g;
        }

        private static Graph createTypeFiveVOne()
        {
            //Creates the first Type Five graph
            Graph g = new Graph(38, new List<Edge>(){new Edge(1,2,8), new Edge(1,3,13),
                                                      new Edge(2,3,13), new Edge(2,9,29), new Edge(2,10,9),
                                                      new Edge(3,4,1), new Edge(3,8,14),
                                                      new Edge(4,5,2), new Edge(4,6,24), new Edge(4,7,20),
                                                      new Edge(5,6,28), new Edge(5,8,18), new Edge(5,15,3),
                                                      new Edge(6,7,4), new Edge(6,15,7),
                                                      new Edge(7,16,28), new Edge(7,17,11),
                                                      new Edge(8,10,26), new Edge(8,15,18),
                                                      new Edge(9,10,8), new Edge(9,11,20), new Edge(9,12,25),
                                                      new Edge(10,11,7), new Edge(10,14,12), new Edge(10,13,11),
                                                      new Edge(11,12,3), new Edge(11,21,12),
                                                      new Edge(12,21,11), new Edge(12,22,3), new Edge(12,23,12), new Edge(12,38,4),
                                                      new Edge(13,14,25), new Edge(13,18,1), new Edge(13,19,10), new Edge(13,20,7), new Edge(13,21,20),
                                                      new Edge(14,15,14), new Edge(14,18,26),
                                                      new Edge(15,16,29), new Edge(15,18,5),
                                                      new Edge(16,17,14), new Edge(16,18,3),
                                                      new Edge(17,27,25), new Edge(17,28,30),
                                                      new Edge(18,19,14), new Edge(18,26,30), new Edge(18,27,22), new Edge(18,30,7),
                                                      new Edge(19,20,13), new Edge(19,24,2), new Edge(19,25,23), new Edge(19,26,11),
                                                      new Edge(20,21,10), new Edge(20,24,27), new Edge(20,33,13), new Edge(20,35,29),
                                                      new Edge(21,23,20), new Edge(21,24,24), new Edge(21,35,28), new Edge(21,36,20),
                                                      new Edge(22,23,19),
                                                      new Edge(23,35,3), new Edge(23,36,22), new Edge(23,38,28),
                                                      new Edge(24,33,16), new Edge(24,34,22), new Edge(24,35,26),
                                                      new Edge(25,30,28), new Edge(25,31,14), new Edge(25,33,23),
                                                      new Edge(26,30,7), new Edge(26,31,6),
                                                      new Edge(27,28,18), new Edge(27,30,15),
                                                      new Edge(28,29,28), new Edge(28,30,15),
                                                      new Edge(29,30,12), new Edge(29,31,17), new Edge(29,32,10),
                                                      new Edge(30,31,16), new Edge(30,32,24),
                                                      new Edge(31,32,14), new Edge(31, 34, 7),
                                                      new Edge(32,33,26),
                                                      new Edge(33,34,29), new Edge(33,37,16),
                                                      new Edge(34,35,17), new Edge(34,36,13), new Edge(34, 37, 11),
                                                      new Edge(35,36,6),
                                                      new Edge(36,37,12), new Edge(36,38,19),
                                                      new Edge(37,38,27)});
            return g;
        }
        private static Graph createTypeFiveVTwo()
        {
            Graph g = new Graph(30, new List<Edge>() { new Edge(1, 2, 8), new Edge(1, 3, 30), new Edge(1, 13, 24), new Edge(1, 14, 28), new Edge(1, 15, 12), new Edge(1, 16, 29), new Edge(1, 19, 13), new Edge(1, 20, 1),
                                                        new Edge(2, 3, 29),
                                                        new Edge(3, 4, 16), new Edge(3, 9, 28), new Edge(3, 10, 8), new Edge(3, 11, 17),
                                                        new Edge(4, 5, 29), new Edge(4, 6, 15), new Edge(4, 10, 25), new Edge(4, 11, 14), new Edge(4, 12, 13), new Edge(4, 13, 24), new Edge(4, 29, 6),
                                                        new Edge(5, 6, 7), new Edge (5, 7 , 9), new Edge(5, 9, 12), new Edge(5, 10, 28), new Edge(5, 29, 40),
                                                        new Edge(6, 7, 10), new Edge(6, 9, 11),
                                                        new Edge(7, 8, 18), new Edge(7, 9, 27), new Edge(7, 10, 23), new Edge(7, 29, 21),
                                                        new Edge(8, 9, 9),
                                                        new Edge(9, 10, 28),
                                                        new Edge(10, 11, 22), new Edge(10, 12, 1), new Edge(10, 23, 1),
                                                        new Edge(11, 13, 26), new Edge(11, 23, 17), new Edge(11, 24, 24), new Edge(11, 27, 18), new Edge(11, 29, 25),
                                                        new Edge(12, 13, 18), new Edge(12, 18, 23), new Edge(12, 21, 10), new Edge(12, 22, 5),
                                                        new Edge(13, 14, 6), new Edge(13, 15, 16), new Edge(13, 19, 24), new Edge(13, 22, 25),
                                                        new Edge(14, 15, 30), new Edge(14, 18, 14),
                                                        new Edge(15, 16, 18), new Edge(15, 17, 24), new Edge(15, 19, 5),
                                                        new Edge(16, 17, 6), new Edge(16, 19, 29),
                                                        new Edge(18, 19, 23), new Edge(18, 20, 15),
                                                        new Edge(19, 20, 19), new Edge(19, 21, 27), new Edge(19, 22, 5),
                                                        new Edge(20, 21, 29),
                                                        new Edge(21, 22, 27), new Edge(21, 23, 29), new Edge(21, 26, 10),
                                                        new Edge(23, 24, 29), new Edge(23, 25, 24), new Edge(23, 26, 17),
                                                        new Edge(24, 26, 17), new Edge(24, 29, 24),
                                                        new Edge(25, 26, 5), new Edge(25, 28, 25), new Edge(25, 29, 9),
                                                        new Edge(26, 27, 14), new Edge(26, 30, 13),
                                                        new Edge(27, 28, 22), new Edge(27, 30, 16),
                                                        new Edge(28, 29, 25), new Edge(28, 30, 17),
                                                        new Edge(29, 30, 27)});
            return g;
        }

        private static Graph createTypeSixVOne()
        {
            Graph g = new Graph(40, new List<Edge>(){new Edge(1, 2, 26), new Edge(1, 7, 10), new Edge(1, 8, 6), new Edge(1, 9, 6),
                                                        new Edge(2, 3, 24), new Edge(2, 6, 12), new Edge(2, 7, 6), new Edge(2, 8, 20), new Edge(2, 12, 5),
                                                        new Edge(3, 4, 27), new Edge(3, 5, 24), new Edge(3, 6, 15), new Edge(3, 12, 8), new Edge(3, 13, 9),
                                                        new Edge(4, 5, 29), new Edge(4, 13, 7), new Edge(4, 14, 22),
                                                        new Edge(5, 6, 14), new Edge(5, 12, 15), new Edge(5, 13, 15), new Edge(5, 14, 6),
                                                        new Edge(6, 7, 9), new Edge(6, 12, 16), new Edge(6, 17, 17),
                                                        new Edge(7, 8, 22), new Edge(7, 9, 10), new Edge(7, 10, 29), new Edge(7, 12, 19), new Edge(7, 16, 12), new Edge(7, 17, 23), new Edge(7, 20, 22),
                                                        new Edge(8, 10, 30),
                                                        new Edge(9, 10, 7), new Edge(9, 18, 29),
                                                        new Edge(10, 11, 23), new Edge(10, 18, 7), new Edge(10, 20, 30),
                                                        new Edge(11, 18, 6), new Edge(11, 20, 16), new Edge(11, 29, 23),
                                                        new Edge(12, 13, 24), new Edge(12, 15, 25), new Edge(12, 16, 16),
                                                        new Edge(13, 14, 18), new Edge(13, 15, 18), new Edge(13, 16, 13), new Edge(13, 24, 25),
                                                        new Edge(14, 15, 13), new Edge(14, 24, 9), new Edge(14, 25, 5),
                                                        new Edge(15, 16, 5), new Edge(15, 22, 25), new Edge(15, 24, 1),
                                                        new Edge(16, 17, 26), new Edge(16, 21, 14), new Edge(16, 22, 10), new Edge(16, 24, 25), new Edge(16, 28, 24), new Edge(16, 29, 9),
                                                        new Edge(17, 21, 17),
                                                        new Edge(18, 19, 28), new Edge(18, 20, 19), new Edge(18, 30, 1),
                                                        new Edge(19, 20, 26), new Edge(19, 30, 19), new Edge(19, 31, 16),
                                                        new Edge(20, 21, 24), new Edge(20, 29, 17), new Edge(20, 30, 29), new Edge(20, 31, 22), new Edge(20, 36, 29),
                                                        new Edge(21, 29, 26),
                                                        new Edge(22, 23, 18), new Edge(22, 24, 22), new Edge(22, 28, 12), new Edge(22, 34, 1),
                                                        new Edge(23, 24, 16), new Edge(23, 25, 26), new Edge(23, 27, 225), new Edge(23, 28, 28), new Edge(23, 34, 10),
                                                        new Edge(26, 27, 10), new Edge(26, 34, 20),
                                                        new Edge(27, 28, 13), new Edge(27, 33, 17),
                                                        new Edge(28, 29, 25), new Edge(28, 32, 24), new Edge(28, 34, 10), new Edge(28, 35, 10),
                                                        new Edge(29, 30, 27), new Edge(29, 31, 7), new Edge(29, 32, 9), new Edge(29, 36, 11), new Edge(29, 37, 10),
                                                        new Edge(30, 31, 15), new Edge(30, 37, 8), new Edge(30, 38, 16), new Edge(30, 39, 11),
                                                        new Edge(31, 36, 19), new Edge(31, 37, 21),
                                                        new Edge(32, 35, 14), new Edge(32, 36, 16),
                                                        new Edge(33, 34, 26),
                                                        new Edge(34, 35, 19),
                                                        new Edge(35, 36, 28),
                                                        new Edge(36, 37, 28),
                                                        new Edge(37, 38, 15), new Edge(37, 39, 21),
                                                        new Edge(38, 39, 7), new Edge(38, 40, 23),
                                                        new Edge(39, 40, 25)});
            return g;
        }
        private static Graph createTypeSixVTwo()
        {
            Graph g = new Graph(40, new List<Edge>() { new Edge(1, 2, 6), new Edge(1, 40, 16),
                                                        new Edge(2, 3, 14), new Edge(2, 5, 8), new Edge(2, 6, 15), new Edge(2, 9, 28), new Edge(2, 10, 27),
                                                        new Edge(3, 4, 22), new Edge(3, 5, 17), new Edge(3, 8, 13),
                                                        new Edge(4, 5, 23),
                                                        new Edge(5, 6, 20), new Edge(5, 8, 16), new Edge(5, 9, 1),
                                                        new Edge(6, 7, 13), new Edge(6, 10, 26),
                                                        new Edge(7, 8, 18), new Edge(7, 11, 9), new Edge(7, 14, 7),
                                                        new Edge(8, 9, 16),
                                                        new Edge(9, 10, 23),
                                                        new Edge(10, 14, 24),
                                                        new Edge(11, 12, 28), new Edge(11, 15, 28), new Edge(11, 20, 5),
                                                        new Edge(12, 13, 20), new Edge(12, 16, 14), new Edge(12, 18, 27),
                                                        new Edge(13, 14, 23), new Edge(13, 15, 5), new Edge(13, 19, 25),
                                                        new Edge(14, 15, 12),
                                                        new Edge(15, 16, 27), new Edge(15, 19, 22), new Edge(15, 20, 17),
                                                        new Edge(16, 17, 20), new Edge(16, 18, 8),
                                                        new Edge(17, 18, 16), new Edge(17, 21, 30), new Edge(17, 24, 1),
                                                        new Edge(18, 19, 16),
                                                        new Edge(19, 20, 18),
                                                        new Edge(20, 24, 11),
                                                        new Edge(21, 22, 29), new Edge(21, 25, 5), new Edge(21, 29, 9),
                                                        new Edge(22, 23, 16), new Edge(22, 25, 23), new Edge(22, 30, 13),
                                                        new Edge(23, 24, 13), new Edge(23, 26, 14), new Edge(23, 29, 21),
                                                        new Edge(24, 25, 25),
                                                        new Edge(25, 26, 14), new Edge(25, 29, 25), new Edge(25, 30, 6),
                                                        new Edge(26, 27, 22), new Edge(26, 29, 25),
                                                        new Edge(27, 28, 13), new Edge(27, 31, 215), new Edge(27, 34, 1),
                                                        new Edge(28, 29, 19),
                                                        new Edge(29, 30, 7),
                                                        new Edge(30, 34, 13),
                                                        new Edge(31, 32, 15), new Edge(31, 35, 23), new Edge(31, 40, 7),
                                                        new Edge(32, 33, 5), new Edge(32, 36, 18), new Edge(32, 39, 30),
                                                        new Edge(33, 34, 28), new Edge(33, 35, 19), new Edge(33, 38, 24),
                                                        new Edge(34, 35, 24),
                                                        new Edge(35, 36, 28), new Edge(35, 38, 30), new Edge(35, 40, 22),
                                                        new Edge(36, 37, 26), new Edge(36, 39, 5),
                                                        new Edge(37, 38, 13),
                                                        new Edge(38, 39, 26),
                                                        new Edge(39, 40, 30)});
            return g;
        }

        private static Graph createTypeSevenVOne()
        {
            Graph g = new Graph(12, new List<Edge>() { new Edge(1, 2, 8), new Edge(1, 4, 22), new Edge(1, 5, 24), new Edge(1, 6, 7), new Edge(1, 8, 15), new Edge(1, 9, 17), new Edge(1, 10, 121), new Edge(1, 11, 1),
                                                        new Edge(2, 3, 23), new Edge(2, 4, 12), new Edge(2, 5, 29), new Edge(2, 6, 13), new Edge(2, 7, 29), new Edge(2, 10, 12), new Edge(2, 12, 6),
                                                        new Edge(3, 4, 7), new Edge(3, 5, 5), new Edge(3, 6, 23),
                                                        new Edge(4, 5, 12), new Edge(4, 6, 24), new Edge(4, 7, 5), new Edge(4, 8, 9), new Edge(4, 10, 17), new Edge(4, 11, 6), new Edge(4, 12, 16),
                                                        new Edge(5, 6, 17), new Edge(5, 7, 5), new Edge(5, 8, 30), new Edge(5, 9, 19), new Edge(5, 11, 22), new Edge(5, 12, 21),
                                                        new Edge(6, 7, 9), new Edge(6, 8, 18), new Edge(6, 9, 12), new Edge(6, 10, 24), new Edge(6, 12, 17),
                                                        new Edge(7, 8, 8), new Edge(7, 10, 20),
                                                        new Edge(8, 9, 12),
                                                        new Edge(9, 10, 24), new Edge(9, 11, 20),
                                                        new Edge(10, 11, 14), new Edge(10, 12, 29),
                                                        new Edge(11, 12, 13)});
            return g;
        }
        private static Graph createTypeSevenVTwo()
        {
            Graph g = new Graph(10, new List<Edge>() { new Edge(1, 2, 26), new Edge(1, 3, 10), new Edge(1, 9, 15), new Edge(1, 10, 5),
                                                        new Edge(2, 3, 28), new Edge(2, 4, 23), new Edge(2, 5, 26), new Edge(2, 7, 22), new Edge(2, 8, 8), new Edge(2, 9, 26), new Edge(2, 10, 30),
                                                        new Edge(3, 4, 16), new Edge(3, 5, 19), new Edge(3, 7, 20), new Edge(3, 8, 25), new Edge(3, 9, 28), new Edge(3, 10, 17),
                                                        new Edge(4, 5, 7), new Edge(4, 6, 6), new Edge(4, 7, 19), new Edge(4, 8, 27), new Edge(4, 9, 5), new Edge(4, 10, 28),
                                                        new Edge(5, 6, 23), new Edge(5, 7, 8), new Edge(5, 8, 29), new Edge(5, 9, 23), new Edge(5, 10, 5),
                                                        new Edge(6, 7, 16), new Edge(6, 8, 7),
                                                        new Edge(7, 8, 6), new Edge(7, 9, 20), new Edge(7, 10, 9),
                                                        new Edge(8, 9, 17), new Edge(8, 10, 20),
                                                        new Edge(9, 10, 6)});
            return g;
        }

        private static Graph createTypeEightVOne()
        {
            Graph g = new Graph(27, new List<Edge>() { new Edge(1, 2, 13), new Edge(1, 3, 5), new Edge(1, 11, 21), new Edge(1, 12, 23), new Edge(1, 13, 16), new Edge(1, 14, 26), new Edge(1, 15, 5), new Edge(1, 16, 7),
                                                        new Edge(2, 3, 23), new Edge(2, 4, 16), new Edge(2, 11, 16), new Edge(2, 13, 11), new Edge(2, 14, 30),
                                                        new Edge(3, 4, 5), new Edge(3, 5, 15), new Edge(3, 11, 21), new Edge(3, 14, 22),
                                                        new Edge(4, 5, 25), new Edge(4, 6, 26), new Edge(4, 7, 24), new Edge(4, 13, 8),
                                                        new Edge(5, 6, 19), new Edge(5, 8, 23), new Edge(5, 9, 7), new Edge(5, 10, 6), new Edge(5, 11, 21), new Edge(5, 22, 27),
                                                        new Edge(6, 7, 19), new Edge(6, 9, 11), new Edge(6, 10, 11), new Edge(6, 11, 21),
                                                        new Edge(7, 8, 19), new Edge(7, 9, 8),
                                                        new Edge(8, 9, 12), new Edge(8, 20, 16), new Edge(8, 21, 6), new Edge(8, 22, 5),
                                                        new Edge(9, 10, 14), new Edge(9, 11, 23), new Edge(9, 18, 7), new Edge(9, 19, 15), new Edge(9, 20, 15), new Edge(9, 21, 14), new Edge(9, 22, 15), new Edge(9, 23, 25),
                                                        new Edge(10, 11, 6), new Edge(10, 12, 29), new Edge(10, 17, 9), new Edge(10, 18, 7), new Edge(10, 19, 8), new Edge(10, 22, 21), new Edge(10, 23, 25),
                                                        new Edge(11, 12, 18), new Edge(11, 13, 23), new Edge(11, 14, 25), new Edge(11, 17, 5), new Edge(11, 18, 13),
                                                        new Edge(12, 13, 6), new Edge(12, 15, 22), new Edge(12, 16, 30), new Edge(12, 17, 25), new Edge(12, 18, 30),
                                                        new Edge(13, 14, 14), new Edge(13, 15, 23), new Edge(13, 16, 21), new Edge(13, 17, 15), new Edge(13, 26, 21),
                                                        new Edge(14, 15, 20),
                                                        new Edge(15, 16, 11), new Edge(15, 17, 25),
                                                        new Edge(16, 17, 15), new Edge(16, 26, 19),
                                                        new Edge(17, 18, 27), new Edge(17, 19, 11), new Edge(17, 22, 27), new Edge(17, 23, 25), new Edge(17, 24, 8), new Edge(17, 25, 18), new Edge(17, 26, 27), new Edge(17, 27, 17),
                                                        new Edge(18, 19, 28), new Edge(18, 22, 23), new Edge(18, 25, 18),
                                                        new Edge(19, 20, 26), new Edge(19, 21, 22), new Edge(19, 22, 18), new Edge(19, 25, 7),
                                                        new Edge(20, 21, 23), new Edge(20, 22, 23), new Edge(20, 23, 19),
                                                        new Edge(21, 22, 20), new Edge(21, 23, 23),
                                                        new Edge(22, 23, 25), new Edge(22, 24, 9), new Edge(22, 25, 23),
                                                        new Edge(23, 24, 19), new Edge(23, 25, 16),
                                                        new Edge(24, 25, 15), new Edge(24, 26, 12), new Edge(24, 27, 21),
                                                        new Edge(25, 26, 14), new Edge(25, 27, 5),
                                                        new Edge(26, 27, 30)});
            return g;
        }
        private static Graph createTypeEightVTwo()
        {
            Graph g = new Graph(20, new List<Edge>() { new Edge(1, 2, 5), new Edge(1, 3, 19), new Edge(1, 4, 27), new Edge(1, 6, 19), new Edge(1, 7, 24), new Edge(1, 10, 11),
                                                        new Edge(2, 3, 25), new Edge(2, 4, 8), new Edge(2, 5, 12), new Edge(2, 6, 17), new Edge(2, 7, 5), new Edge(2, 8, 19), new Edge(2, 10, 16),
                                                        new Edge(3, 4, 17), new Edge(3, 5, 9), new Edge(3, 6, 8), new Edge(3, 8, 13),
                                                        new Edge(4, 5, 6), new Edge(4, 7, 12), new Edge(4, 10, 29), new Edge(4, 11, 11), new Edge(4, 12, 19),
                                                        new Edge(5, 6, 30), new Edge(5, 7, 6), new Edge(5, 8, 6), new Edge(5, 9, 10), new Edge(5, 10, 16), new Edge(5, 11, 27), new Edge(5, 12, 11),
                                                        new Edge(6, 7, 7), new Edge(6, 8, 12), new Edge(6, 9, 19), new Edge(6, 10, 21),
                                                        new Edge(7, 8, 30), new Edge(7, 9, 24), new Edge(7, 10, 6),
                                                        new Edge(8, 10, 28), new Edge(8, 15, 23), new Edge(8, 16, 9), new Edge(8, 17, 8), new Edge(8, 18, 10),
                                                        new Edge(9, 10, 5), new Edge(9, 11, 15), new Edge(9, 12, 5), new Edge(9, 19, 18), new Edge(9, 20, 30),
                                                        new Edge(10, 11, 23), new Edge(10, 12, 6),
                                                        new Edge(12, 13, 26), new Edge(12, 14, 26),
                                                        new Edge(13, 14, 22), new Edge(13, 15, 10), new Edge(13, 16, 11), new Edge(13, 17, 16), new Edge(13, 18, 23), new Edge(13, 19, 23), new Edge(13, 20, 13),
                                                        new Edge(14, 15, 15), new Edge(14, 16, 23), new Edge(14, 17, 7), new Edge(14, 18, 28), new Edge(14, 19, 14), new Edge(14, 20, 25),
                                                        new Edge(15, 16, 26), new Edge(15, 17, 28), new Edge(15, 18, 26), new Edge(15, 19, 20), new Edge(15, 20, 20),
                                                        new Edge(16, 17, 27), new Edge(16, 18, 16), new Edge(16, 19, 6), new Edge(16, 20, 17),
                                                        new Edge(17, 18, 22), new Edge(17, 19, 14), new Edge(17, 20, 16),
                                                        new Edge(18, 19, 16), new Edge(18, 20, 28),
                                                        new Edge(19, 20, 8)});
            return g;
        }

        private static Graph createTypeNineVOne()
        {
            Graph g = new Graph(46, new List<Edge>() { new Edge(1, 2, 14), new Edge(1, 3, 12), new Edge(1, 4, 28), new Edge(1, 5, 28), new Edge(1, 18, 20), new Edge(1, 19, 14), new Edge(1, 20, 23), new Edge(1, 21, 12), new Edge(1, 25, 27), new Edge(1, 29, 7),
                                                        new Edge(2, 3, 7), new Edge(2, 4, 13), new Edge(2, 5, 18), new Edge(2, 19, 19), new Edge(2, 20, 22), new Edge(2, 21, 12), new Edge(2, 23, 15),
                                                        new Edge(3, 4, 6), new Edge(3, 5, 30), new Edge(3, 6, 19), new Edge(3, 7, 25), new Edge(3, 9, 16), new Edge(3, 17, 14),
                                                        new Edge(4, 5, 15), new Edge(4, 6, 30), new Edge(4, 19, 20),
                                                        new Edge(5, 6, 20), new Edge(5, 17, 26), new Edge(5, 19, 22), new Edge(5, 20, 19),
                                                        new Edge(6, 7, 16), new Edge(6, 8, 13), new Edge(6, 16, 22), new Edge(6, 17, 12), new Edge(6, 19, 10),
                                                        new Edge(7, 8, 8), new Edge(7, 9, 20), new Edge(7, 10, 8), new Edge(7, 11, 26), new Edge(7, 13, 6), new Edge(7, 16, 22), new Edge(7, 17, 15), new Edge(7, 31, 14),
                                                        new Edge(8, 9, 12), new Edge(8, 10, 19), new Edge(8, 14, 13), new Edge(8, 15, 27), new Edge(8, 16, 5), new Edge(8, 28, 6),
                                                        new Edge(9, 10, 20), new Edge(9, 13, 27), new Edge(9, 14, 9),
                                                        new Edge(10, 11, 22), new Edge(10, 12, 17), new Edge(10, 13, 22), new Edge(10, 14, 14), new Edge(10, 16, 30), new Edge(10, 42, 22), new Edge(10, 43, 12),
                                                        new Edge(11, 12, 23), new Edge(11, 13, 16), new Edge(11, 14, 17), new Edge(11, 30, 29), new Edge(11, 32, 14), new Edge(11, 46, 6),
                                                        new Edge(12, 13, 22), new Edge(12, 30, 25), new Edge(12, 31, 30), new Edge(12, 32, 18), new Edge(12, 33, 5), new Edge(12, 46, 19),
                                                        new Edge(13, 14, 20), new Edge(13, 28, 27), new Edge(13, 29, 23), new Edge(13, 30, 18), new Edge(13, 31, 7),
                                                        new Edge(14, 15, 26),
                                                        new Edge(15, 16, 17), new Edge(15, 17, 24), new Edge(15, 18, 14), new Edge(15, 23, 22), new Edge(15, 29, 18), new Edge(15, 30, 14),
                                                        new Edge(16, 17, 8), new Edge(16, 18, 28), new Edge(16, 29, 29),
                                                        new Edge(17, 18, 9), new Edge(17, 19, 5), new Edge(17, 22, 6), new Edge(17, 23, 28), new Edge(17, 27, 8),
                                                        new Edge(18, 19, 30), new Edge(18, 20, 15), new Edge(18, 21, 17), new Edge(18, 23, 10), new Edge(18, 29, 26),
                                                        new Edge(19, 20, 5),
                                                        new Edge(20, 21, 8), new Edge(20, 22, 5), new Edge(20, 23, 17), new Edge(20, 24, 29), new Edge(20, 27, 21),
                                                        new Edge(21, 22, 6), new Edge(21, 23, 15), new Edge(21, 24, 29), new Edge(21, 25, 19), new Edge(21, 26, 30), new Edge(21, 29, 20), new Edge(21, 36, 12), new Edge(21, 45, 18),
                                                        new Edge(22, 23, 5), new Edge(22, 25, 8), new Edge(22, 26, 9),
                                                        new Edge(23, 24, 16),
                                                        new Edge(24, 25, 22), new Edge(24, 27, 28), new Edge(24, 28, 20), new Edge(24, 29, 18), new Edge(24, 36, 16),
                                                        new Edge(25, 26, 17), new Edge(25, 27, 30), new Edge(25, 35, 15), new Edge(25, 36, 12), new Edge(25, 38, 228), new Edge(25, 40, 1),
                                                        new Edge(26, 27, 129), new Edge(26, 35, 15), new Edge(26, 38, 1),
                                                        new Edge(27, 28, 29), new Edge(27, 34, 19), new Edge(27, 35, 9),
                                                        new Edge(28, 29, 9), new Edge(28, 32, 30), new Edge(28, 33, 27), new Edge(28, 34, 26),
                                                        new Edge(29, 30, 13), new Edge(29, 35, 11),
                                                        new Edge(30, 31, 6), new Edge(30, 32, 20), new Edge(30, 46, 28),
                                                        new Edge(31, 32, 22), new Edge(31, 33, 18),
                                                        new Edge(32, 33, 23), new Edge(32, 45, 6), new Edge(32, 46, 6),
                                                        new Edge(33, 34, 26), new Edge(33, 43, 123), new Edge(33, 44, 24), new Edge(33, 45, 1),
                                                        new Edge(34, 35, 10), new Edge(34, 44, 30), new Edge(34, 45, 18),
                                                        new Edge(35, 36, 25), new Edge(35, 37, 13), new Edge(35, 40, 23),
                                                        new Edge(36, 37, 16), new Edge(36, 38, 13), new Edge(36, 39, 17), new Edge(36, 40, 1),
                                                        new Edge(37, 38, 29), new Edge(37, 39, 13), new Edge(37, 40, 116), new Edge(37, 41, 25), new Edge(37, 42, 22), new Edge(37, 44, 1),
                                                        new Edge(38, 39, 14), new Edge(38, 40, 12),
                                                        new Edge(39, 40, 26), new Edge(39, 41, 27), new Edge(39, 43, 16),
                                                        new Edge(40, 41, 18), new Edge(40, 44, 16),
                                                        new Edge(41, 42, 17), new Edge(41, 43, 15), new Edge(41, 44, 26),
                                                        new Edge(42, 43, 22), new Edge(42, 43, 18), new Edge(42, 46, 15),
                                                        new Edge(43, 44, 30), new Edge(43, 45, 30), new Edge(43, 46, 10),
                                                        new Edge(44, 45, 17), new Edge(44, 46, 21),
                                                        new Edge(45, 46, 14)});
            return g;
        }
        private static Graph createTypeNineVTwo()
        {
            Graph g = new Graph(41, new List<Edge>() { new Edge(1, 2, 29), new Edge(1, 3, 8), new Edge(1, 15, 8), new Edge(1, 16, 29), new Edge(1, 17, 25), new Edge(1, 19, 15), new Edge(1, 20, 19), new Edge(1, 21, 11),
                                                        new Edge(2, 3, 24), new Edge(2, 11, 9), new Edge(2, 15, 22), new Edge(2, 16, 28), new Edge(2, 17, 30),  new Edge(2, 20, 9), new Edge(2, 21, 19),
                                                        new Edge(3, 4, 23), new Edge(3, 10, 6), new Edge(3, 11, 8), new Edge(3, 12, 17), new Edge(3, 14, 10), new Edge(3, 15, 30),
                                                        new Edge(4, 5, 17), new Edge(4, 6, 22), new Edge(4, 7, 6), new Edge(4, 8, 19), new Edge(4, 9, 20), new Edge(4, 10, 19), new Edge(4, 12, 12),
                                                        new Edge(5, 6, 10), new Edge(5, 7, 28), new Edge(5, 8, 12), new Edge(5, 9, 20), new Edge(5, 40, 5),
                                                        new Edge(6, 7, 17), new Edge(6, 8, 18), new Edge(6, 9, 18), new Edge(6, 31, 20),
                                                        new Edge(7, 8, 20), new Edge(7, 9, 5), new Edge(7, 10, 25), new Edge(7, 25, 10), new Edge(7, 26, 27),
                                                        new Edge(8, 9, 20), new Edge(8, 10, 17), new Edge(8, 11, 8), new Edge(8, 12, 17),
                                                        new Edge(9, 10, 18), new Edge(9, 25, 16), new Edge(9, 26, 17),
                                                        new Edge(10, 11, 10), new Edge(10, 12, 29), new Edge(10, 15, 25),
                                                        new Edge(11, 12, 6), new Edge(11, 14, 14), new Edge(11, 15, 8), new Edge(11, 16, 18),
                                                        new Edge(12, 13, 14), new Edge(12, 18, 23), new Edge(12, 25, 8),
                                                        new Edge(13, 14, 12), new Edge(13, 16, 25), new Edge(13, 18, 27), new Edge(13, 22, 23), new Edge(13, 23, 22), new Edge(13, 24, 228), new Edge(13, 27, 16),
                                                        new Edge(14, 15, 24), new Edge(14, 16, 16), new Edge(14, 17, 18), new Edge(14, 19, 12), new Edge(14, 20, 29),
                                                        new Edge(15, 16, 25), new Edge(15, 20, 10),
                                                        new Edge(16, 17, 10), new Edge(16, 20, 23),
                                                        new Edge(17, 18, 19), new Edge(17, 19, 10), new Edge(17, 20, 13), new Edge(17, 21, 8),
                                                        new Edge(18, 19, 19), new Edge(18, 21, 28), new Edge(18, 22, 20), new Edge(18, 23, 16), new Edge(18, 24, 11),
                                                        new Edge(19, 20, 29), new Edge(19, 21, 24), new Edge(19, 22, 10), new Edge(19, 23, 16),
                                                        new Edge(20, 21, 21),
                                                        new Edge(21, 22, 230), new Edge(21, 28, 1),
                                                        new Edge(22, 23, 26), new Edge(22, 24, 15), new Edge(22, 25, 12), new Edge(22, 28, 17),
                                                        new Edge(23, 24, 23), new Edge(23, 26, 13), new Edge(23, 27, 25), new Edge(23, 29, 22),
                                                        new Edge(24, 25, 12), new Edge(24, 26, 12), new Edge(24, 27, 28), new Edge(24, 28, 25),
                                                        new Edge(25, 26, 30), new Edge(25, 27, 6), new Edge(25, 31, 30),
                                                        new Edge(26, 27, 19), new Edge(26, 29, 17), new Edge(26, 31, 18),
                                                        new Edge(27, 28, 26), new Edge(27, 29, 15), new Edge(27, 31, 23),
                                                        new Edge(28, 29, 22), new Edge(28, 31, 7), new Edge(28, 32, 29), new Edge(28, 41, 9),
                                                        new Edge(29, 30, 23), new Edge(29, 31, 29), new Edge(29, 32, 28), new Edge(29, 41, 7),
                                                        new Edge(30, 31, 8), new Edge(30, 32, 30), new Edge(30, 33, 5), new Edge(30, 34, 30), new Edge(30, 35, 29), new Edge(30, 40, 24), new Edge(30, 41, 21),
                                                        new Edge(31, 32, 26),
                                                        new Edge(32, 33, 10), new Edge(32, 34, 16), new Edge(32, 35, 17), new Edge(32, 41, 30),
                                                        new Edge(33, 34, 5), new Edge(33, 35, 30), new Edge(33, 36, 16), new Edge(33, 37, 18), new Edge(33, 38, 216), new Edge(33, 40, 1),
                                                        new Edge(34, 35, 5), new Edge(34, 36, 20), new Edge(34, 37, 7), new Edge(34, 38, 8), new Edge(34, 40, 30),
                                                        new Edge(35, 36, 5), new Edge(35, 37, 26), new Edge(35, 38, 29), new Edge(35, 40, 26),
                                                        new Edge(36, 37, 27), new Edge(36, 38, 8), new Edge(36, 39, 24), new Edge(36, 40, 17), new Edge(36, 41, 18),
                                                        new Edge(37, 38, 29), new Edge(37, 39, 26), new Edge(37, 40, 29), new Edge(37, 41, 23),
                                                        new Edge(38, 39, 19), new Edge(38, 40, 15), new Edge(38, 41, 6),
                                                        new Edge(39, 40, 22),
                                                        new Edge(40, 41, 19)});
            return g;
        }

        private static Graph completeFiveVertex()
        {
            Graph g = new Graph(5, new List<Edge>() { new Edge(1, 2, 24), new Edge(1, 3, 16), new Edge(1, 4, 8), new Edge(1, 5, 18),
                                                        new Edge(2, 3, 12), new Edge(2, 4, 29), new Edge(2, 5, 21),
                                                        new Edge(3, 4, 15), new Edge(3, 5, 22),
                                                        new Edge(4, 5, 10)});
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

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void imageBox_Click(object sender, EventArgs e)
        {

        }
    }
}
