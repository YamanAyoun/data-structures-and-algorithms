namespace TestStackandQueue
{
    public class UnitTest1
    {
        //Stack Tests
        [Fact]
        public void TestPush()
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();
            stack.Push("1");
            Assert.Equal("{1} -> NULL", stack.ToString());
        }

        [Fact]
        public void TestPushMultiple()
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            Assert.Equal("{3} -> {2} -> {1} -> NULL", stack.ToString());
        }

        [Fact]
        public void TestPop()
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Pop(); 
            Assert.Equal("{1} -> NULL", stack.ToString());
        }

        [Fact]
        public void TestPopMultiple()
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();
            stack.Push("1");
            stack.Push("2");
            stack.Pop(); 
            stack.Pop(); 
            Assert.Equal("The Stack is Empty", stack.ToString());
        }

        [Fact]
        public void TestStackPeek()
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();
            stack.Push("1");
            stack.Push("2");
            Assert.Equal("2", stack.Peek());
        }

        [Fact]
        public void TestEmptyStack()
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestStackExceptions()
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();
            Assert.Throws<Exception>(stack.Peek);
            Assert.Throws<Exception>(stack.Pop);
        }

        //Queue Tests
        [Fact]
        public void TestEnqueue()
        {
            stack_and_queue.Queue queue = new stack_and_queue.Queue();
            queue.Enqueue("1");
            Assert.Equal("{1} -> NULL", queue.ToString());
        }

        [Fact]
        public void TestEnqueueMultiple()
        {
            stack_and_queue.Queue queue = new stack_and_queue.Queue();
            queue.Enqueue("5");
            queue.Enqueue("2");
            queue.Enqueue("3");
            Assert.Equal("{5} -> {2} -> {3} -> NULL", queue.ToString());
        }

        [Fact]
        public void TestDequeue()
        {
            stack_and_queue.Queue queue = new stack_and_queue.Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Dequeue(); 
            Assert.Equal("{2} -> NULL", queue.ToString());
        }

        [Fact]
        public void TestQueuePeek()
        {
            stack_and_queue.Queue queue = new stack_and_queue.Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            Assert.Equal("1", queue.Peek());
        }

        [Fact]
        public void TestDequeueMultiple()
        {
            stack_and_queue.Queue queue = new stack_and_queue.Queue();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Dequeue(); 
            queue.Dequeue(); 
            Assert.Equal("The Queue is Empty", queue.ToString());
        }

        [Fact]
        public void TestEmptyQueue()
        {
            stack_and_queue.Queue queue = new stack_and_queue.Queue();
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void TestQueueExceptions()
        {
            stack_and_queue.Queue queue = new stack_and_queue.Queue();
            Assert.Throws<Exception>(queue.Peek);
            Assert.Throws<Exception>(queue.Dequeue);
        }
    }
}