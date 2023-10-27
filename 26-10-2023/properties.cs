using System;

class Employee{
    public int id { get; set; } //auto implpemented property

    public string name {get; set; }
    
    public string loc = "Gujarat";

    public string location 
    {
        get
        {
             return loc; //local variable
        }
    }

    int mbnum;

    public int mobile 
    {
        set
        {
            mbnum = value;
        }
    } 

}

class A
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee();
        e1.id = 101;
        e1.name = "Vijaya";

        System.Console.WriteLine("Employee id 1 : " + e1.id);
        System.Console.WriteLine("Employee name 1 : " + e1.name);


        Employee e2 = new Employee();
        e2.id = 102;
        e2.name ="Raju";

        System.Console.WriteLine("Employee id 2 : " + e2.id);
        System.Console.WriteLine("Employee name 2 : " + e2.name);


        //read only demo

        System.Console.WriteLine("Employee location is :" + e1.location);
        
        e1.mobile = 653464; // cannot read

    }
}