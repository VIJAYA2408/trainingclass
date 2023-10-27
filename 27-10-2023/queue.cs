using System; 
using System.Collections; 
  
public class queue { 
    static void Main(string[] args) 
    { 
  
        Queue q1 = new Queue(); 
  
        q1.Enqueue("vijaya"); 
        q1.Enqueue("s/w trainee"); 
        q1.Enqueue("executive"); 
        Console.WriteLine("Total count of queue: {0}", q1.Count);
        foreach(var i in q1) 
        { 
            System.Console.WriteLine(i); 
        } 

        q1.Dequeue();
        Console.WriteLine("Total count of queue: {0}", q1.Count);



    }

} 
  