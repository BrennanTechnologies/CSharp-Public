using System;

public class Animal  // Base class (parent) 
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