# Code Challenge 11: stack-queue-pseudo

## Whiteboard Process
![stack and queue pseudo](Asserts/cc9.png)

## Approach & Efficiency

Enqueue method, the space complexity, it is a O(1), and for the time complexity it is also a O(1)  becouse I used stack method push  where I just keep pushing to the first stack.

Dequeue method, the space complexity, it is a O(1), and for the time complexity it is also a O(n) since I have to use loops. becouse  I empty the first stack values and push them to the second stack,
then pop one value and then push all the values from stack2 to stack1.

## Solution

public void Enqueue(string value)
        {
            while (stack1.top != null)
            {
                stack2.Push(stack1.Pop());
            }

            stack1.Push(value);

            while (stack2.top != null)
            {
                stack1.Push(stack2.Pop());
            }
        }
        public void Dequeue()
        {
            if (stack1.top != null)
            {
                stack1.Pop();
            }
            else
            {
                throw new Exception("The Queue is Empty");
            }

        }

