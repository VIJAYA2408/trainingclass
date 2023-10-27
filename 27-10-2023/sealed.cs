using System;

sealed class A
{
    public void function1()
    {
        System.Console.WriteLine("function1() is invoked");
    }

}

class B: A
{
    public void function2()
    {
        System.Console.WriteLine("function2() is invoked");
    }

}

class myclass
{
    static void Main(string[] args)
    {
        A obj1= new A();
        obj1.function1();

        B obj2 = new B();
        obj2.function2();
    }

}