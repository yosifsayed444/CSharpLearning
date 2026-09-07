using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp2
{
    

    //implementation of inheritance and Encapsulation
    internal class Animal
    {
        public string AnimalName { get; set; }
        public DateOnly BirthDate { get; set; }


        public string publicVariable;
        private string privateVariable;
        protected string protectedVariable;
        internal string internalVariable;


        public void TrainAnimalPublic()
        {
            Console.WriteLine($"Training {AnimalName} born on {BirthDate}");
        }
        private void TrainAnimalPrivate()
        {
            Console.WriteLine($"Training {AnimalName} born on {BirthDate}");
        }
        protected void TrainAnimalProtected()
        {
            Console.WriteLine($"Training {AnimalName} born on {BirthDate}");
        }
        internal void TrainAnimalInternal()
        {
            Console.WriteLine($"Training {AnimalName} born on {BirthDate}");
        }
    }

    class Dog : Animal   // can access internal and public and protected members of base class
    {

        public void UseProtectedVariable() // protected variable can be accessed in derived class
        {
            Console.WriteLine(protectedVariable);
        }
        public void bark()
        {
            Console.WriteLine($"{AnimalName} is barking");
        }

    }

    class Bird : Animal
    {
        public string BirdSpecies { get; set; }
        public void fly()
        {
            Console.WriteLine($"{AnimalName} is flying");
        }
    }



    //implementation of nested classes
    class OuterClassAnimal
    {
        public string AnimalName { get; set; }
        public int AnimalAge { get; set; }

        public class InnerClassDog : OuterClassAnimal
        {
            public string DogBreed { get; set; }
            public void bark() { }

        }
        public class InnerClassBird
        {
            public string BirdSpecies { get; set; }
            public void fly() { }
        }

    }
}
