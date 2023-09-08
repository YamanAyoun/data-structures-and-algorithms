# Code Challenge: Class 12
## Problem Doamin
Create a class called AnimalShelter which holds only dogs and cats, using a first-in, first-out approach.

methods:
1. ``Enqueue``
Arguments: animal

2. ``Dequeue``
Arguments: pref
pref can be either "dog" or "cat"
Return: either a dog or a cat, based on preference.


## Approach & Efficiency
Enqueue method time complixity is O(1), because we don't have any iterate in this process.<br />
Dequeue method time complixity is O(1), because we don't have any iterate in this process<br />

## Solution
To Enqueue or Dequeue you should create an AnimalShelter object like I did in ``main`` and call the method.<br>
``AnimalShelter animalShelter = new AnimalShelter();``<br />
``animalShelter.Enqueue(new Cat());``<br />
``animalShelter.Dequeue("cat");``<br />
