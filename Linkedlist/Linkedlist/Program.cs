using System;
using System.Collections.Generic;

namespace Linkedlist
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Data Structure Problem.");
           
            Linkedliste list = new Linkedliste();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();



            Linkedliste list2 = new Linkedliste();
            list2.Add(70);
            list2.AddBefore(30);
            list2.AddBefore(56);
            list.Display();


            Linkedliste list3 = new Linkedliste();
            list3.Add(56);
            list3.Add(30);
            list3.Add(70);
            list3.Display();
        }
    }
}


