using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public Node<AnyType> GetNode(int index)
        {
            Node<AnyType> current = head;
            for(int i = 0; i < index && i < this.Count; i++)
                current = current.next;
            return current;
        }

        public Node<AnyType> GetNode(AnyType data)
        {
            Node<AnyType> current = head;
            for(int i = 0; i < this.Count; i++)
            {
                if (current.data.Equals(data))
                    return current;
                current = current.next;
            }
            return null;
        }

        public AnyType GetNodeData(int index)
        {
            return GetNode(index).data;
        }
    }
}
