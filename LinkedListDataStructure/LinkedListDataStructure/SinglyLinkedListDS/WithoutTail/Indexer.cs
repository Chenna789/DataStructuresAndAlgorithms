using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public object this[int index]
        {
            get { return this.GetNodeData(index); }
            set { this.SetNodeData(index, value); }
        }
    }
}
