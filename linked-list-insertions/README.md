# Code Challenge 06: linked-list-insertions
Write methods for the Linked List class:

1. Append
2. Insert Before
3. Insert After

## Approach & Efficiency
Append method time complixity is O(n) becouse the worst case, where the linked list has n nodes, the method iterates over all nodes until it reaches the last node.<br />
Insert Before method time complixity is O(n) becouse the worst case, the given value is not found in the linked list so loop is iterates over all nodes<br />
Insert After method time complixity is O(n) becouse the worst case, the given value is not found in the linked list, and the method iterates over all nodes.<br />


## Solution


Append : to Insert a new Node for last list.<br />
![image 1](linked-list-insertions/Asserts/img1.png)

Insert Before method:
![image 2](linked-list-insertions/Asserts/img2.png)

Insert After method
![image 3](linked-list-insertions/Asserts/img3.png)

![image 4](linked-list-insertions/Asserts/img4.png)
you can see in the list, how 5 insert after 4
and how 0 insert before 1
![image 5](linked-list-insertions/Asserts/img5.png)
