using System.Collections.Generic;

namespace Day6_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            SimpleLinkedList myList = new SimpleLinkedList();
            myList.AddNode(56);
            myList.AddNode(30);
            myList.AddNode(70);

            Console.WriteLine("Linked List: ");
            myList.DisplayList();
        }
    }
}