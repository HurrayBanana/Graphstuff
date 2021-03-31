using System;
using System.Collections.Generic;
using System.Text;

namespace Graphstuff
{
    class Tree
    {
        public TreeNode root;

        public Tree()
        {
            root = null;
        }

        public void Add(TreeNode node)
        {
            //special case adding to empty tree
            if (root == null)
            {
                root = node;
            }
            else
            {
                TreeNode current = root;
                while (current != null)
                {
                    if (current.intData > current.intData)
                        current = current.Left;
                    else
                        current = current.Right;
                }
                current = node;
            }
        }
    }
}
