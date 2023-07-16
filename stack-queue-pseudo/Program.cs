namespace stack_queue_pseudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pseudoQueue pseudoQueue = new pseudoQueue();
            pseudoQueue.Enqueue("5");
            pseudoQueue.Enqueue("10");
            pseudoQueue.Enqueue("15");
            pseudoQueue.Enqueue("20");
            pseudoQueue.Dequeue();
            

            Console.WriteLine(pseudoQueue.Peek());
        }
    }
}