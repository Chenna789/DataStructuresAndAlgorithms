using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail
    {
        public void RemoveWith_O_1(Node node)
        {
            node.data = node.next.data;
            Node temp = node.next;//not needed
            node.next = node.next.next;
            temp = null;//not needed - just to clear off resources
            Count--;
        }
    }
}
