// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class queue
{
    static void Main(string[] args)
    {
        Queue q1 = new Queue();
        q1.Enqueue(10);
        q1.Enqueue(65);
        q1.Enqueue(96);
        q1.Enqueue(12);
        q1.Enqueue(610);
        System.Console.WriteLine("Queue elements are: ");
        foreach(int i in q1)
        {
            System.Console.WriteLine(i);
        }
        System.Console.WriteLine("Queue Count is : " + q1.Count);
        
        q1.Dequeue();
        q1.Dequeue();
        System.Console.WriteLine("DeQueue elements are: ");
        foreach(int i in q1)
        {
            System.Console.WriteLine(i);
        }
        System.Console.WriteLine("DeQueue Count is : " + q1.Count);
    
    }
}