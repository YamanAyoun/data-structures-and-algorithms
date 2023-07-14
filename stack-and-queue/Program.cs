namespace stack_and_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stack_and_queue.Stack stack = new stack_and_queue.Stack();

            stack.Push("1");
            stack.Push("2");
            stack.Push("3");
            stack.Push("4");

            Console.WriteLine(stack.Peek());
        }
    }
}