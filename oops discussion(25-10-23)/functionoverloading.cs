using System;

class mainclass
{
    static void Main(string[] args)
    {
        mainclass obj = new mainclass();
        obj.add(10);
        obj.add(10,2);
        obj.add(5,6,7);

    }

    public void add(int a)
    {
        System.Console.WriteLine("Addition result is: " +(a+a));
    }

    public void add(int a,int b)
    {
        System.Console.WriteLine("Addition result is: " +(a+b));

    }

    public void add(int a,int b,int c)
    {
        System.Console.WriteLine("Addition result is: " +(a+b+c));

    }
}