﻿using System;
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
            BinaryTreeDS<int> tree = new BinaryTreeDS<int>();
            tree.Insert(10);
            tree.Insert(9);
            tree.Insert(8);
            tree.Insert(7);
            tree.Insert(11);
            tree.Insert(12);
            tree.Insert(13);
            Console.WriteLine(tree);
        }
    }
}