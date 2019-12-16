using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeDataStructure.BinaryTree
{
    partial class BinaryTreeDS<AnyType>
    {
        public void Insert(AnyType data)
        {
            if (root == null)
                root = new Node<AnyType>(data);
            else
            {
                Node<AnyType> current = root;
                while(true)
                {
                    if(Comparer<AnyType>.Default.Compare(data, current.data) < 0)
                    {
                        if (current.left == null)
                        {
                            current.left = new Node<AnyType>(data);
                            return;
                        }
                        current = current.left;
                    }
                    else
                    {
                        if (current.right == null)
                        {
                            current.right = new Node<AnyType>(data);
                            return;
                        }
                        current = current.right;
                    }
                }
            }
        }
    }
}
