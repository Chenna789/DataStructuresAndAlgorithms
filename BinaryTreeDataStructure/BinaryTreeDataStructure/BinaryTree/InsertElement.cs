using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDataStructure.BinaryTree
{
    partial class BinaryTreeDS<AnyType>
    {

        public void InsertWithRecursion(AnyType data)
        {
            if (this.root == null)
            {
                this.root = new Node<AnyType>(data);
                count++;
            }
            else
                InsertWithRecursion(root, data);
        }
        private void InsertWithRecursion(Node<AnyType> root, AnyType data)
        {
            if (Comparer<AnyType>.Default.Compare(data, root.data) < 0)
            {
                if (root.left == null)
                {
                    root.left = new Node<AnyType>(data);
                    count++;
                    return;
                }
                InsertWithRecursion(root.left, data);
            }
            else if(Comparer<AnyType>.Default.Compare(data, root.data) > 0)
            {
                if (root.right == null)
                {
                    root.right = new Node<AnyType>(data);
                    count++;
                    return;
                }
                InsertWithRecursion(root.right, data);
            }
        }
        public void Insert(AnyType data)
        {
            if (root == null)
            {
                root = new Node<AnyType>(data);
                count++;
            }
            else
            {
                Node<AnyType> current = root;
                while (true)
                {
                    if (Comparer<AnyType>.Default.Compare(data, current.data) < 0)
                    {
                        if (current.left == null)
                        {
                            current.left = new Node<AnyType>(data);
                            count++;
                            return;
                        }
                        current = current.left;
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            current.right = new Node<AnyType>(data);
                            count++;
                            return;
                        }
                        current = current.right;
                    }
                }
            }
        }
    }
}
