using System;

namespace RTX
{
    class Animal  // Base class (parent) 
    {
        //public abstract void animalSound();
        
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }

        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        /* 
         * Main Method:
         * ----------------
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program!");

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();



            // String: 
            // ------
            //string fName = "Chris";
            //string lName = "Brennan";
            //MyStrings(fName, lName);

            // Add:
            // ----
            //Console.WriteLine(MyMethod(5, 10));

            // Car:
            // -----
            //string model = "Ford";
            //string color = "red";
            //int year = 2024;
            //Car myObj = new Car(model, color, year);
            //Console.WriteLine("Model: " + myObj.color);
            //Console.WriteLine("MaxSpeed: " + myObj.maxSpeed);
            //Console.WriteLine($"Model: {myObj.model} Color: {myObj.color} MaxSpeed: {myObj.maxSpeed}");
            //myObj.fullThrottle();

        }


        /* 
         * My Methods:
         * ----------------
         */
        static void MyStrings(string fName, string lName)
        {
            Console.WriteLine("fName: " + fName);
            Console.WriteLine("lName: " + lName);
            Console.WriteLine($"{fName} {lName}");

        }

        static int MyMethod(int x, int y)
        {
            return x + y;
        }
    }
}

