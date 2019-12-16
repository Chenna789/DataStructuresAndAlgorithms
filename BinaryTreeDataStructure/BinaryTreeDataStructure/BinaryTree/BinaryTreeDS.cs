using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDataStructure.BinaryTree
{
    partial class BinaryTreeDS<AnyType>
    {
        private Node<AnyType> root;
        public override string ToString()
        {
            Node<AnyType> current = root;
            Console.WriteLine("Right side ");
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.right;
            }
            current = root;
            Console.WriteLine("Left side ");
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.left;
            }
            return "";
        }
    }
}
