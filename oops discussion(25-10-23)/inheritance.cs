using System;

class myclass1
{
    public void function1()
    {
        System.Console.WriteLine("myclass 1 ---- function1() is invoked");
    }

}

class myclass2 : myclass1{    //single level inheritance
    public void function2()
    {
        System.Console.WriteLine("myclass 2 ---- function2() is invoked");
    }
}

class myclass3 : myclass2 {   //multi level inheritance
    public void function3()
    {
        System.Console.WriteLine("myclass 3 ---- function3() is invoked");
    }
}



class mainclass
{
    static void Main(string[] args)
    {
        myclass2 obj1 = new myclass2();
        obj1.function1();
        obj1.function2();
        myclass3 obj2 = new myclass3();
        obj2.function3();

    }
     
        // myclass1 obj = new myclass1();
        // obj.myclass1();

}