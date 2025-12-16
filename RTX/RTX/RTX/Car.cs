using System;

namespace RTX
{
	class Car
	{
		public string model;
		public int year;
		public string color = "red";        // field
		public int maxSpeed = 200;          // field

		// Create a class constructor with multiple parameters
		public Car(string modelName, string modelColor, int modelYear)
		{
			model = modelName;
			color = modelColor;
			year  = modelYear;
		}

		public void fullThrottle()   // method
		{
			Console.WriteLine("The car is going as fast as it can!");
		}

		public void hitBreak()   // method
		{
			Console.WriteLine("eeeEEKKK!!!");
		}
	}
}
