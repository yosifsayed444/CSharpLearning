using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Enemy
    {
        static int count = 0;
        static int instanceCount = 0;
        // Properties set and get
        public int Id { get; set; }
        public string Name { get; set; }
        public double health { get; set; }


        // Default constructor
        public Enemy()
        {
            Console.WriteLine("Default constructor calling ");
            Console.WriteLine("New enemy is created");
            health = 100;
            instanceCount++;
            Console.WriteLine($"Instance constructor called {instanceCount} times");
        }
        // Parameterized constructor
        public Enemy(string name, double health)
        {
            Name = name;
            Console.WriteLine("Parametarized constructor calling ");
            Console.WriteLine($"New enemy is created with name {name}, and health {health}");
            this.health = health;
        }
        // Copy constructor
        public Enemy(Enemy enemy)
        {
            Console.WriteLine("Copy constructor calling ");
            health = enemy.health;
            Name = enemy.Name;
            Console.WriteLine($"{health} , {Name}");

        }
        // static constructor is called only once when the class is first loaded into memory
        static Enemy()
        {
            Console.WriteLine("Static constructor calling ");
            count++;
            Console.WriteLine($"Static constructor called {count} times");
        }
        // Static method can be called without creating an instance of the class
        public static void StaticMethod()
        {
            Console.WriteLine("Static method calling ");
   
        }
        // Non static method can be called only after creating an instance of the class
        public void NonStaticMethod()
        {
            Console.WriteLine("Non static method calling ");
        }
    }


    internal class Counter
    {
        public static int count = 0;
        //private constructor to prevent instantiation
        private Counter()
        {
            count = 0;
        }
        public static void Increment()
        {
            count++;
        }
        public static void Decrement()
        {
            count--;
        }
        public static int GetCount()
        {
            return count;
        }
    }

}
