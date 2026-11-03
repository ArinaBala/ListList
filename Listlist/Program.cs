using System;
using System.Collections.Generic;
using System.Text; 

namespace ListList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Tvarina> initialAnimals = new List<Tvarina>()
            {
                new Pug("Adolf", 5, "Pug"),
                new Cat("Мурчик", 12, true),
                new Parrot("Кеша", 2, true)
            };

            Zoopark zoo = new Zoopark("Казковий світ", initialAnimals);

            zoo.AddAnimal(new Pug("Граф", 15, "Дворняга"));
            zoo.AddAnimal(new Cat("Барсик", 1, false));

            Console.WriteLine("=== Початковий список тварин у зоопарку ===");
            Console.WriteLine(zoo);

          
            ushort N = 10;
            Console.WriteLine($"=== Видалення тварин, старших за {N} років ===");
            zoo.RemoveOlderThan(N);

            Console.WriteLine("\n=== Оновлений список тварин ===");
            Console.WriteLine(zoo);
        }
    }
}