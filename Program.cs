using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace AppParcial1Scripting
{
    class Program
    {
        static void Main()
        {
            Node node1 = new Node(0, 0);
            //Node node2 = new Node(1, 0);
            Node node3 = new Node(2, 0);
            Node node4 = new Node(3, 0);
            Node node5 = new Node(4, 0);
            Node node6 = new Node(0, 1);
            //Node node7 = new Node(1, 1);
            Node node8 = new Node(2, 1);
            //Node node9 = new Node(3, 1);
            Node node10 = new Node(4, 1);
            Node node11 = new Node(0, 2);
            //Node node12 = new Node(1, 2);
            Node node13 = new Node(2, 2);
            Node node14 = new Node(3, 2);
            Node node15 = new Node(4, 2);
            Node node16 = new Node(0, 3);
            //Node node17 = new Node(1, 3);
            Node node18 = new Node(2, 3);
            //Node node19 = new Node(3, 3);
            Node node20 = new Node(4, 3);
            Node node21 = new Node(0, 4);
            Node node22 = new Node(1, 4);
            Node node23 = new Node(2, 4);
            //Node node24 = new Node(3, 4);
            Node node25 = new Node(4, 4);

            Node[] maze = { node1, node3, node4, node5, node6, node8, node10, node11, node13, node14, node15, node16, node18, node20, node21, node22, node22, node23, node25 };

            SearchPath searchPath = new SearchPath();
            //
            searchPath.nodes = maze;
            searchPath._startingPoint = node1;
            searchPath._endingPoint = node25;

            //

            List<Node> _path = searchPath.Path;

            Console.WriteLine(" I x 0 0 0 \n 0 x 0 x 0 \n 0 x 0 0 0 \n 0 x 0 x 0 \n 0 0 0 x F \n\n");
            for (int i = 0; i < _path.Count; i++)
            {
                Console.WriteLine(i + ".    (" + (_path[i].GetPos().Item1) + ", " + (_path[i].GetPos().Item2) + ")");
            }

            Console.WriteLine("Time elapsed: {0}", searchPath.timeElapsed.ToString("hh\\:mm\\:ss\\.fff")); // Mostrar el tiempo transcurriodo con un formato hh:mm:ss.000
        }  
    }
}

/*
I x 0 0 0
0 x 0 x 0
0 x 0 0 0
0 x 0 x 0
0 0 0 x F
*/