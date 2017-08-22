using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int info;
        public Node leftLink;
        public Node rightLink;

        public Node(int info)
        {
            this.info = info;
            leftLink = null;
            rightLink = null;
        }
    }
}
