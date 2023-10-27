using System;

interface myinterface1
{
    public void function1();
}

interface myinterface2
{
    public void function2();
}

class india: myinterface1, myinterface2
{
    public void function1()
    {
        System.Console.WriteLine("Hello from function1()");
    }

     public void function2()
    {
        System.Console.WriteLine("Hello from function2()");
    }


}