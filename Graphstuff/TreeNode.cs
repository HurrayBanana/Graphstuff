using System;
using System.Collections.Generic;
using System.Text;

namespace Graphstuff
{
    class TreeNode : Node
    {
        const int LEFT = 0;
        const int RIGHT = 1;
        public TreeNode(TreeNode node)
            :base(node)
        {
        }
        public TreeNode Left
        {
            get {
                if (Neighbours.Count == 0)
                    return null;
                else 
                    return (TreeNode)Neighbours[LEFT]; }
            set {
                if (Neighbours.Count )
                Neighbours[LEFT] = value;}
        }
        public TreeNode Right
        {
            get { return (TreeNode)Neighbours[RIGHT]; }
            set { Neighbours[RIGHT] = value; }
        }
    }
}
