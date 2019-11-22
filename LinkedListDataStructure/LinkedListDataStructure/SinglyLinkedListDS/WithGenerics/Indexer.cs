using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public AnyType this[int index]
        {
            get { return this.GetNodeData(index); }
            set { this.SetNodeData(index, value); }
        }
    }
}
