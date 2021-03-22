using System;
using System.Collections.Generic;
using System.Text;

namespace Graphstuff
{
    class TreeNode : Node
    {
        /// <summary>
        /// clear way of specifying which node is the left branch
        /// </summary>
        const int LEFT = 0;
        /// <summary>
        /// clear way of specifying which node is the right branch
        /// </summary>
        const int RIGHT = 1;
        /// <summary>
        /// constructs a tree node with 2 branches
        /// </summary>
        /// <param name="data"></param>
        public TreeNode(object data)
            :base(data)
        {
            //create neighbours for the left and right branches
            base.AddNeighbour(null);
            base.AddNeighbour(null);
        }
        /// <summary>
        /// accessor for the node following the left branch
        /// </summary>
        public TreeNode Left
        {
            get {return (TreeNode)Neighbours[LEFT]; }
            set {Neighbours[LEFT] = value;}
        }
        /// <summary>
        /// accessor for the node following the right branch
        /// </summary>
        public TreeNode Right
        {
            get { return (TreeNode)Neighbours[RIGHT]; }
            set { Neighbours[RIGHT] = value; }
        }
    }
}
