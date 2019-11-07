using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsProject
{
    class Edge
    {
        int v1;
        int v2;
        int distance;

        public Edge(int vertexOne, int vertexTwo, int dist)
        {
            v1 = vertexOne;
            v2 = vertexTwo;
            distance = dist;
        }

        public int vertexOne()
        {
            return v1;
        }

        public int vertexTwo()
        {
            return v2;
        }

        public int getLength()
        {
            return distance;
        }

        public void switchVertices()
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
