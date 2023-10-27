using System;

class customer
{
    public int  custId {get; set;}

    public string custName {get; set;}

    public float salary {get; set;}

    public string location {get;set;}


}

class Program{
    static void Main(string[] args)
    {
        customer cust = new customer();

        cust.custId = 101;
        cust.custName = "Viji";
        cust.salary = 20000;
        cust.location ="chennai";

        System.Console.WriteLine(cust.custId);
        System.Console.WriteLine(cust.custName);
        System.Console.WriteLine(cust.salary);
        System.Console.WriteLine(cust.location);

    }
}