using System;
namespace UC5_DeleteFirstElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.pop(56);
            list.Display();
        }
    }
}