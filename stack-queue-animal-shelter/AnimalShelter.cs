using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_animal_shelter
{
    public class AnimalShelter
    {


        Queue cats = new Queue();
        Queue dogs = new Queue();

        int catCount = 1;
        int dogCount = 1;

        public void Enqueue(Animal animal)
        {
            if (animal is Cat)
            {
                cats.Enqueue("Cat :" + catCount);
                catCount++;
            }
            else if (animal is Dog)
            {
                dogs.Enqueue("Dog :" + dogCount);
                dogCount++;
            }
        }

        public string Dequeue(string pref)
        {
            if (pref == "cat")
            {
                return cats.Dequeue();
            }
            else if (pref == "dog")
            {
                return dogs.Dequeue();
            }
            return null;
        }
    }

    public class Animal
    {
    }

    public class Cat : Animal
    {
    }

    public class Dog : Animal
    {
    }


    /// ///////////
  
    public class Node
        {
            public string Data { get; set; }
            public Node Next;

            public Node(string Data)
            {
                this.Data = Data;
                Next = null;
            }
        }


    /// ////////

        public class Queue
        {
            public Node front = null;
            public Node back = null;

            public void Enqueue(string value)
            {
                Node node = new Node(value);
                if (back == null)
                {
                    back = node;
                    front = back;
                }
                else
                    back.Next = node;
                back = node;
            }

            public string Dequeue()
            {
                if (front == null)
                {
                    throw new Exception("The Queue is Empty");
                }
                Node temp = front;
                front = front.Next;
                temp.Next = null;
                return temp.Data;
            }

            public string Peek()
            {
                if (front == null)
                {
                    throw new Exception("The Queue is Empty");
                }
                else
                    return front.Data;
            }

            public bool IsEmpty()
            {
                return front == null;
            }

            public string ToString()
            {
                string result = "";

                if (front == null)
                {
                    return "The Queue is Empty";
                }
                else
                {
                    Node current = front;
                    while (current != null)
                    {
                        result += "{" + current.Data + "} -> ";
                        current = current.Next;
                    }
                }

                return result + "NULL";
            }
        }
    }
