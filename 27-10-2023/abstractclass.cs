using System;

abstract class vehicle
{
    public abstract void color();
    public void engine() //non abstract method
    {
        System.Console.WriteLine("Engine make is : 2000");
    }
}

class car:vehicle
{
    public override void color()
    {
        System.Console.WriteLine("color is green");
    }

}

class myclass
{
    static void Main(string[] args)
    {

    }
}