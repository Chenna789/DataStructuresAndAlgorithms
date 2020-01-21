using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTreeDataStructure.BinaryTree;

namespace BinaryTreeDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeDS<int> tree1 = new BinaryTreeDS<int>();
            tree1.Insert(20);
            tree1.Insert(15);
            tree1.Insert(25);
            tree1.Insert(13);
            tree1.Insert(18);

            BinaryTreeDS<int> tree2 = new BinaryTreeDS<int>();
            tree2.InsertWithRecursion(20);
            tree2.InsertWithRecursion(15);
            tree2.InsertWithRecursion(25);
            tree2.InsertWithRecursion(13);
            tree2.InsertWithRecursion(18);

            Console.Write("Inorder Traversal with recursion tree1: ");
            tree1.InorderTraversalWithRecursion(tree1.root);
            Console.WriteLine();

            Console.Write("Inorder Traversal with recursion tree2: ");
            tree2.InorderTraversalWithRecursion(tree2.root);
            Console.WriteLine();

            Console.Write("Inorder Traversal without recursion tree1: ");
            tree1.InOrderTravesalWithoutRecursion(tree1.root);
            Console.WriteLine();

            Console.Write("Inorder Traversal without recursion tree2: ");
            tree2.InOrderTravesalWithoutRecursion(tree2.root);
            Console.WriteLine();

            Console.Write("Preorder Traversal with recursion tree1: ");
            tree1.PreorderTraversalWithRecursion(tree1.root);
            Console.WriteLine();

            Console.Write("Preorder Traversal with recursion tree2: ");
            tree2.PreorderTraversalWithRecursion(tree2.root);
            Console.WriteLine();

            Console.Write("Preorder Traversal with recursion tree1: ");
            tree1.PreorderTraversalWithRecursion(tree1.root);
            Console.WriteLine();

            Console.Write("Preorder Traversal with recursion tree2: ");
            tree2.PreorderTraversalWithRecursion(tree2.root);
            Console.WriteLine();
        }
    }
}
