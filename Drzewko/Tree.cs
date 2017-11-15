using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drzewko
{

    /// <summary>
    ///  Class of binary tree
    /// </summary>
    /// <typeparam name="Titem">Type of items in binary tree.</typeparam>
    class Tree<Titem> where Titem : IComparable<Titem>
    {
        /// <summary>
        /// Contains data of current tree node.
        /// </summary>
        public Titem Node { get; set; }
        /// <summary>
        /// Reference to left branch.
        /// </summary>
        public Tree<Titem> LeftTree { get; set; }
        /// <summary>
        /// Reference to right branch.
        /// </summary>
        public Tree<Titem> RightTree { get; set; }

        /// <summary>
        /// Create new branch of tree.
        /// </summary>
        /// <param name="node">Data in branch</param>
        public Tree(Titem node)
        {
            this.Node = node;
            this.LeftTree = null;
            this.RightTree = null;
        }

        /// <summary>
        /// Inserting new node into tree
        /// </summary>
        /// <param name="newNode">New data to store inside binary tree. It must inherit IComparable</param>
        public void InsertNode(Titem newNode)
        {
            Titem currentNode = this.Node;

            if (currentNode.CompareTo(newNode) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<Titem>(newNode);
                }
                else
                {
                    this.LeftTree.InsertNode(newNode);
                }
            }
            else
            {
                if(this.RightTree == null)
                {
                    this.RightTree = new Tree<Titem>(newNode);
                }
                else
                {
                    this.RightTree.InsertNode(newNode);
                }
            }

        }

        /// <summary>
        /// It gets all data from binary tree and sort ascending.
        /// </summary>
        /// <returns>String with all nodes sortes ascending.</returns>
        public string WalkTree()
        {
            string result = string.Empty;

            if(this.LeftTree != null)
            {
                result += this.LeftTree.WalkTree();
            }

            result +=  $" {this.Node.ToString()} ";

            if(this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }

            return result;
        }
    }
}
