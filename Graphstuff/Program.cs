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
        }
    }
}
