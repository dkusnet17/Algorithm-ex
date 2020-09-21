using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        LinkedList<int> myList = new LinkedList<int>();

        // Add 6 elements in the linked list
        myList.AddLast(1);
        myList.AddLast(3);
        myList.AddLast(5);
        myList.AddLast(7);
        myList.AddLast(9);




        foreach (var i in myList)
        {
            Console.WriteLine(i);
            myList.Skip(1);
        }
    }

}
