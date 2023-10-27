using System;

class car{
    public car()
    {
        System.Console.WriteLine("Car constructor is invoked");
    }

    public car(string color)   //parameterized constructor
    {
        System.Console.WriteLine("Car color is : " + color);
    }
}

class vehicle
{
    static void Main(string[] args)
    {
        car obj = new car();   //used to invoke default constructor
        car obj1 = new car("red");    //used to invoked parameterized constructor
    }
}