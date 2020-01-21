using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDataStructure.BinaryTree
{
    partial class BinaryTreeDS<AnyType>
    {
        public void InorderTraversalWithRecursion(Node<AnyType> root)
        {
            if (root == null)
                return;

            var left = root.left;
            if (left != null)
                InorderTraversalWithRecursion(left);

            Console.Write(root.data + " ");

            var right = root.right;
            if (right != null)
                InorderTraversalWithRecursion(right);

        }

        public void InOrderTravesalWithoutRecursion(Node<AnyType> node)
        {
            if (root == null)
                return;

            Stack<Node<AnyType>> stack = new Stack<Node<AnyType>>();
            Node<AnyType> current = root;

            while(current != null || stack.Count > 0)
            {
                while(current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                current = stack.Pop();
                Console.Write(current.data + " ");
                current = current.right;
            }
        }

    }
}
