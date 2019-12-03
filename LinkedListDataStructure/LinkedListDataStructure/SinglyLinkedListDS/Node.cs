using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS
{
    class Node
    {
        public object data;
        public Node next;
        public Node(object data)
        {
            this.data = data;
        }

        public override bool Equals(object obj)
        {
            Node node1 = obj as Node;
            Node node2 = this as Node;
            while (node1 != null || node2 != null)
            {
                if (!node1.data.Equals(node2.data))
                    return false;
                node1 = node1.next;
                node2 = node2.next;
            }
            return true;
        }
    }
}
