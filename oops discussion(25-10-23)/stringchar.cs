using System;

namespace stringChar
{
    class newStringChar
    {
        static void Main(string[] args)
        {
            string s1 = "vijaya";
            string s2 = "WELCOME";

            System.Console.WriteLine("String in upperCASE : " + s1.ToUpper() + ' ' +  s2.ToLower());
            System.Console.WriteLine("String in lowerCASE : " + s2.ToLower());

            if(string.Compare(s1,s2)==0)
            {
                System.Console.WriteLine("Strings are equal");
            }
            else
            {
                System.Console.WriteLine("strings are not equal");
            }
            System.Console.WriteLine("Concate of string :" +  string.Concat(s1,s2));
        }
    }
}