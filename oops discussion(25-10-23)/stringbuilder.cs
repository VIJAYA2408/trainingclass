using System;
using System.Text;
namespace newstringBuilder
{
    class stringbuilder
    {
        static void Main(string[] args)
        {
            StringBuilder addWord = new StringBuilder("Word1");
            addWord.Append(", Word2");
            addWord.Append(", Word3");
            Console.WriteLine(addWord);
        }
    }
}