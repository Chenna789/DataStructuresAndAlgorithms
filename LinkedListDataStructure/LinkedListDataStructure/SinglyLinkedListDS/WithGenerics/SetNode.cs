using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public void SetNodeData(int index, AnyType newData)
        {
            Node<AnyType> current = head;
            for(int i = 0; i < index && i < this.Count; i++)
                current = current.next;
            current.data = newData;
        }
    }
}
