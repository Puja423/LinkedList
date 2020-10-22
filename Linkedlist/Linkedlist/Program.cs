﻿using System;
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

            Linkedliste list4 = new Linkedliste();

            list4.Add(56);
            list4.Add(70);
            list4.InsertAtParticularPosition(2, 30);
            list4.Display();


            Linkedliste list5 = new Linkedliste();
            list5.Add(56);
            list5.Add(30);
            list5.Add(70);
            list5.DeleteFirstNode();
            list5.Display();
        }
    }
}



