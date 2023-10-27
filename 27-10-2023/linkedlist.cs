using System;
using System.Collections.Generic;
 
class linkedlist {
 
    static void Main(string[] args)
    {
 
        LinkedList<string> l1 = new LinkedList<string>();

        l1.Add("Viji");
        l1.Add("Raju");
        l1.Add("Latha");
        l1.Add("Meenu");
 
        foreach(string i in l1)
        {
            Console.WriteLine(i);
        }
 
        l1.Remove(l1.First);
 
        foreach(string i in l1)
        {
            Console.WriteLine(i);
        }
 
        l1.Remove("Raju");
 
        foreach(string i in l1)
        {
            Console.WriteLine(i);
        }
 
        Console.WriteLine("Number of students: {0}",
                                     l1.Count);
    }
}