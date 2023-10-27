using System;

class  car
{
    public car()
    {
        System.Console.WriteLine("Car constructor is invoked");
    }
}

class vehicle
{
    static void Main(string[] args)
    {
        car obj = new car();
    }
    
    
}