using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public void RemoveWith_O_1(Node node)
        {
            node.data = node.next.data;
            Node temp = node.next;
            node.next = node.next.next;
            temp = null;
            Count--;
        }
    }
}
