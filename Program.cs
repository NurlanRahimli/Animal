using System;

namespace tezetema
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Kotik", "black", 7);
            Dog dog = new Dog("Cek", "white", 3);

            Console.WriteLine(cat.GetDetails());
            Console.WriteLine(dog.GetDetails());

        }
    }
}
