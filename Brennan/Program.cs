// See https://aka.ms/new-console-template for more information



using System;

namespace Brennan
{
	class Program
	{
		int myAge = 35;
        string myName = "Chris";


        /* Main Method */
        static void Main(string[] args)
		{
			Console.WriteLine("Start Program!");

			Animal myAnimal = new Animal();  // Create a Animal object
			Animal myPig = new Pig();  // Create a Pig object
									   //Animal myDog = new Dog();  // Create a Dog object

			myAnimal.animalSound();
			myPig.animalSound();
			//myDog.animalSound();

			MyStrings("Chris", "Brennan");

			Console.WriteLine(intAdd(5, 10));

			WriteLog("HelloWorld");


			Console.WriteLine("End Program!");
		}

		/* My Methods */
		static void WriteLog(string msg)
		{
			// Write to Console:
			// ------------------------------------------
			Console.WriteLine($"msg: {msg}");


			// Write to File:
			// ------------------------------------------
			System.IO.File.WriteAllText("log.txt", msg);

		}

		static void MyStrings(string fName, string lName)
		{
			//Console.WriteLine("fName: " + fName);
			//Console.WriteLine("lName: " + lName);
			Console.WriteLine($"{fName} {lName}");
		}

		static int intAdd(int x, int y)
		{
			return x + y;
		}
	}
}


