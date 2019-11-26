# Linked List

A LinkedList is a linear data structure which stores element in the non-contiguous location. The elements in a linked list are linked with each other using pointers Or in other words, LinkedList consists of nodes where each node contains a data field and a reference(link) to the next node in the list.

## Types

There are 3 types of linked lists.

### Singly Linked List:
Each node has refence to a next node and last node will have next node as null. 
   #### Example: 
<img src="LinkedListDataStructure/src/resources/SingleLinkedList.png" height="100" />

 #### Insertion:
   ##### Insert at the Start of Linked List:
Imagine linked list always as a normal chain  where you have a chain and you want to insert a new link on the starting, what will you do? - Get a new link and append to the existing chain starting(head).<br /> <br />
   Node newNode = new Node(10); //Create a new node <br />
   newItem.next = head; //Just link the new item to the existing head. <br />
   head = newItem; //now newItem will become head as we are inserting at the start of linked list.<br />
   
   ###### Complexity:
  Inserting a node at the start of linked list will always have complexiy of O(1)(constant time)
  
  ##### Insertion at the end of Linked List:
To insert a node at the end, we need last node link pointer to add new node. This can be done in two ways. <br />
   1) Getting the last node pointer by iterating through all the nodes from head and hook the last node to it(lastNode.next = newItem). This has the time complexity of O(n)(linear time). <br />
   2) Store a tail pointer like how we are storing head pointer. When ever we add or remove any elements we will have to update the tail pointer like how we update head pointer. If we have a tail pointer, then we don't need to interate through all the nodes. We can just create a new item and hook this new item as next node to the tail pointer and update tail pointer as new node. <br />
      Node newItem = new Node(10); //Create a new node <br />
      tail.next = newItem; //Just link the new item to the existing tail node. <br />
      tail = newItem; //now newItem will become tail as we are inserting at end of the linked list.<br />
   

### Doubly Linked List:
Each node has refence to next node and previous node as well and last node will have next pointer as null.
   #### Example:
<img src="LinkedListDataStructure/src/resources/DoubleLinkedList.jpg" height="150" />

### Circular Linked List:
Each node has refence to next node and previous node as well and last node will have next pointer as starting node circularly. 
   #### Example:
<img src="LinkedListDataStructure/src/resources/CicrcularLinkedList.jpg" height="100" />

##

