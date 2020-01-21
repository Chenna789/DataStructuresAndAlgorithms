using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDataStructure.BinaryTree
{
    partial class BinaryTreeDS<AnyType>
    {
        public void PreorderTraversalWithRecursion(Node<AnyType> root)
        {
            byte b = 2;
            
            if (root == null)
                return;

            Console.Write(root.data + " ");

            var left = root.left;
            if (left != null)
                PreorderTraversalWithRecursion(left);

            var right = root.right;
            if (right != null)
                PreorderTraversalWithRecursion(right);
        }

        public void PreorderTraversalWithoutRecursion(Node<AnyType> root)
        {
            if (root == null)
                return;
            Node<AnyType> current = root;
            Console.Write(current.data + " ");
            Stack<Node<AnyType>> stack = new Stack<Node<AnyType>>();
            while(current != null || stack.Count > 0)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            current = current.right;
        }
    }
}
