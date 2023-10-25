using System;

namespace A{
    class myA
    {
        public void function1()
        {
            System.Console.WriteLine("A - myA - function1() is invoked");
        }
    }
}

namespace B{
    class myB
    {
        public void function2()
        {
            System.Console.WriteLine("B - myB - function2() is invoked");
        }
    }
}

class mainclass{
    static void Main(string[] args)
    {
        A.myA obj1 = new A.myA();
        obj1.function1();

        B.myB obj2 = new B.myB();
        obj2.function2();
    }
}