﻿using System;
using System.Collections;

namespace DataStructureUsingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To the Data structure program using Linked List");
            //Ability To Create LinkedList by Appending
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            linkedList = new LinkedList();
            linkedList.Add2(70);
            linkedList.Add2(30);
            linkedList.Add2(56);
            linkedList.Display();
        }
    }
}