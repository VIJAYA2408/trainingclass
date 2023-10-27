using System;

using System.Collections.Generic;

public class stack{
    static void Main(string[] args)
    {
        Stack st = new Stack();
        st.Push(2);
        st.Push(22);
        st.Push("stack");
        st.Push('v');
        foreach(var i in st)
        {
            System.Console.WriteLine(i);
        }
    }
}