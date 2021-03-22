using System;
using System.Collections.Generic;
using System.Text;

namespace Graphstuff
{
    /// <summary>
    /// holds a Node for a graph
    /// </summary>
    class Node
    {
        /// <summary>
        /// data is of any type, responsibility
        /// for casting is left to the user of the class
        /// </summary>
        private object data;
        /// <summary>
        /// maintains a list of all nodes order implied
        /// </summary>
        private List<Node> neighbours = new List<Node>();
        /// <summary>
        /// returns a list of the nodes neighbouring this one
        /// </summary>
        public List<Node> Neighbours
        {
            get { return neighbours; }
        }
        /// <summary>
        /// constructs the node speciying it's data item
        /// </summary>
        /// <param name="data">the object to store as the data for the node</param>
        public Node(object data)
        {
            this.data = data;
        }
        /// <summary>
        /// accessor (get, set) to read and write the data item
        /// </summary>
        public object Data
        {
            get { return data; }
            set { data = value; }
        }
        /// <summary>
        /// adds a new neighbour to the nodes list
        /// </summary>
        /// <param name="node">the reference to the new neighbour</param>
        public void AddNeighbour(Node node)
        {
            neighbours.Add(node);
        }
        /// <summary>
        /// treat data item as integer
        /// </summary>
        public int intData { get { return (int)data; } }
        /// <summary>
        /// treat data item as string
        /// </summary>
        public string stringData { get { return (string)data; } }
        /// <summary>
        /// treat data item as float
        /// </summary>
        public float floatData { get { return (float)data; } }
    }
}
