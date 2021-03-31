using System;
using System.Collections.Generic;

namespace Graphstuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Tree t = new Tree();
            TreeNode n = new TreeNode(7);
            t.Add(n);
            TreeNode n2 = new TreeNode(12);
            t.Add(n2);
        }
    }
}
