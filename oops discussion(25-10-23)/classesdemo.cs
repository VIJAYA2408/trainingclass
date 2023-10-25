using System;

class myclass1
{
    public void function1()
    {
        System.Console.WriteLine("myclass 1 ---- function1() is invoked");
    }

}

class myclass2{
    public void function2()
    {
        System.Console.WriteLine("myclass 2 ---- function2() is invoked");
    }
}

class mainclass
{
    static void Main(string[] args)
    {
        myclass1 obj = new myclass1();
        obj.function1();

        myclass2 obj1 = new myclass2();
        obj1.function2();

    }
        

        
    
}