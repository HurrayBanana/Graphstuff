using System;
using System.Collections.Generic;

namespace Graphstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node("DAVE");

            Console.WriteLine("Hello World!");
            TreeNode root = new TreeNode("M");
            root.Left = new TreeNode("Z");
            root.Right = new TreeNode("A");


            /*
                B <-- 10 ----- A <------ 5 ----> C
            */

            DijkstraNode dA = new DijkstraNode("A");
            DijkstraNode dB = new DijkstraNode("B");
            DijkstraNode dC = new DijkstraNode("C");

            dA.AddNeighbour(dB, 10);
            dA.AddUndirectedNeighbour(dC, 5);


        }
    }
}
