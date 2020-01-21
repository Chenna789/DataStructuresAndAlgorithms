using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDataStructure.BinaryTree
{
    partial class BinaryTreeDS<AnyType>
    {
        public Node<AnyType> root { get; private set; }

        public int count { get; private set; }
        public override string ToString()
        {
            Node<AnyType> current = root.right;
            Console.WriteLine("Root data is " + root.data);

            Console.WriteLine("Right side ");
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.right;
            }
            current = root.left;
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
