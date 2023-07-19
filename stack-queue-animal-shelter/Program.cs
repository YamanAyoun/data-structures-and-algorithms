namespace stack_queue_animal_shelter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter animalShelter = new AnimalShelter();
            Animal cat = new Cat();
            animalShelter.Enqueue(new Dog());
            animalShelter.Enqueue(new Dog());
            animalShelter.Enqueue(new Cat());
            animalShelter.Enqueue(new Cat());
           
            Console.WriteLine(animalShelter.Dequeue("cat"));
            Console.WriteLine(animalShelter.Dequeue("cat"));

            Console.WriteLine(animalShelter.Dequeue("dog"));
            Console.WriteLine(animalShelter.Dequeue("s"));
        }
    }
}