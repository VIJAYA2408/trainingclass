using System;

class vehicle{
    public virtual void engine()
    {
        System.Console.WriteLine("vehicle has engine");

    }
}

class car:vehicle
{
    public void color()
    {
        System.Console.WriteLine("color is red");
    }

    public override void engine()
    {
        System.Console.WriteLine("car has a engine");
    }

}

class myclass1234
{
    static void Main(string[] args)
    {
        car c1 = new car();
        c1.color();
        c1.engine();
        c1.engine();
    }
}