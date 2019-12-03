using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    class Node<AnyType>
    {
        public Node<AnyType> next;
        public Node<AnyType> prev;
        public AnyType data;
        public Node(AnyType data)
        {
            this.data = data;
        }
    }
}
