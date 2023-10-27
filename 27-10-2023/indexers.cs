using System;

class Program
{
    class IndexerClass
    {
        private string[] names = new string[10];

        public string this[int i]
        {
            get{
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
    static void Main(string[] args)
    {
        IndexerClass Team = new IndexerClass();
        Team[0] = "Rocky";
        Team[1] = "Sam";
        Team[2] = "nawin";
        Team[3] = "Viji";
        Team[4] = "Raju";
        Team[5] = "latha";
        Team[6] = "synthu";
        Team[7] = "meena";
        Team[8] = "bharru";
        Team[9] = "Durai";

        for(int i =0;i<10;i++)
        {
            Console.WriteLine(Team[i]);
        
        }
        Console.ReadKey();
    }
}