﻿using System;
using System.IO;

namespace Pets {
    class Program {
        static void Main(string[] args) {
            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);

            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("Weight: " + pet1.weight);
            Console.WriteLine(pet1.getTag());

            Dog dog1 = new Dog("Daisy", "Kent", 23.4);

            Console.WriteLine("\nName: " + dog1.name);
            Console.WriteLine("Weight: " + dog1.weight);
            Console.WriteLine(dog1.getTag());
            Console.WriteLine(dog1.bark(4));

            Cat cat1 = new Cat("Simba", "Maria", 5.2);

            Console.WriteLine("\nName: " + cat1.name);
            Console.WriteLine("Weight: " + cat1.weight);
            Console.WriteLine(cat1.getTag());
            Console.WriteLine(cat1.meow(3));
        }
    }
}