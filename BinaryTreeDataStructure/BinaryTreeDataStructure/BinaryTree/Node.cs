using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDataStructure.BinaryTree
{
    public class Node<AnyType>
    {
        public AnyType data;
        public Node<AnyType> left;
        public Node<AnyType> right;
        public Node(AnyType data)
        {
            this.data = data;
        }
    }
}
