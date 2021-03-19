using System;
using System.Collections.Generic;
using System.Text;

namespace Graphstuff
{
    class Node
    {
        private object data;
        private List<Node> neighbours = new List<Node>();
        public List<Node> Neighbours
        {
            get { return neighbours; }
        }
        public Node(object data)
        {
            this.data = data;
        }
        public object Data
        {
            get { return data; }
            set { data = value; }
        }
        public void AddNeighbour(Node node)
        {
            neighbours.Add(node);
        }
    }
}
