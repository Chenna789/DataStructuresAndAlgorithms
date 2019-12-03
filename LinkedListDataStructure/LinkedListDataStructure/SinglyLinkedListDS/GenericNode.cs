using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    class Node<AnyType>
    {
        public Node<AnyType> next;
        public AnyType data;
        public Node(AnyType data)
        {
            this.data = data;
        }
    }
}
