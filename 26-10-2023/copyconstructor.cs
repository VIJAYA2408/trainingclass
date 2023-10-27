using System;
namespace A
{
    class User
    {
        public string name,location;

        //Parameterized constructor

        public User(string a, string b)
        {
            name = a;
            location = b;
        }

        //Copy Constructor

        public User(User user)
        {
            name = user.name;
            location = user.location;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //user object with a parameterized constructor
            User user = new User("Vijaya","Bengaluru");

            //Another user object (user1) by copying user details

            User user1 = new User(user);
            user1.name = "Raj";
            user1.location = "Chennai";
            Console.WriteLine(user.name + ", " + user.location);
            Console.WriteLine(user1.name + ", " + user1.location);

            Console.WriteLine("\nPress ENter key to exit..");

            Console.ReadLine();

        }
    }
}