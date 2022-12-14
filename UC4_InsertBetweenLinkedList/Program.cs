using System;
namespace UC4_InsertBetweenLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.InsertAtParticularPosition(2, 30);
            list.Add(70);
            list.Display();
        }
    }
}