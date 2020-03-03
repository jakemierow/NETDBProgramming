using System;
using System.Collections.Generic;
using System.Linq;

namespace YourName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            Dog dog = new Dog();
            dog.name = "Rover";
            dog.Talk();
            animals.Add(dog);
           

            Cat cat = new Cat();
            cat.name = "Whiskers";
            cat.Talk();


            Bird bird = new Bird();
            bird.name = "Polly";
            bird.Talk();


            Console.WriteLine("Yoda Speaks");
            var animal = animals
                .Where(x => x.name == "Yoda")
                .FirstOrDefault();

            animal.Talk();


        }


        public abstract class Animal
        {

            public string name { get; set; }

            public virtual void Talk()
            {
                Console.WriteLine("Hello");
            }
        }


        public class Dog : Animal
        {
            public override void Talk()
            {
                Console.WriteLine("Bark");
            }
        }


        public class Cat : Animal
        {
            public override void Talk()
            {
                Console.WriteLine("Meow");
            }
        }


        public class Bird : Animal
        {
            public override void Talk()
            {
                Console.WriteLine("Cherp");
            }
        }

       
        }





    }

