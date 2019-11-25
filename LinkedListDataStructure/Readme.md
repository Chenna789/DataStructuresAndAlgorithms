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
Imagine linked list always as a normal chain  where you have a chain and you want to insert a new link on the starting, what will you do?
 <br />
   <p> Get a new link and append to the existing chain starting(head).</p> <br /> <br />
   Node newNode = new Node(10); //Create a new node <br />
   newItem.next = head; //Just link the new item to the existing head. <br />
   head = newItem; //now newItem will become head as we are inserting at the start of linked list. <br />

### Doubly Linked List:
Each node has refence to next node and previous node as well and last node will have next pointer as null.
   #### Example:
<img src="LinkedListDataStructure/src/resources/DoubleLinkedList.jpg" height="150" />

### Circular Linked List:
Each node has refence to next node and previous node as well and last node will have next pointer as starting node circularly. 
   #### Example:
<img src="LinkedListDataStructure/src/resources/CicrcularLinkedList.jpg" height="100" />

##

