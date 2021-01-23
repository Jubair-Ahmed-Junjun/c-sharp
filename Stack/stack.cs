using System;
using System.Collections.Generic;

namespace Stack_QueueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> mySatack = new Stack<string>();
            mySatack.Push("Jubair Ahmed Junjun");
            mySatack.Push("BGCTUB");
            mySatack.Push("018549xxxxx");
            mySatack.Push("Chittagong");
            foreach(string data in mySatack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(mySatack.Count);
            mySatack.Pop();
            Console.WriteLine(mySatack.Count);
            foreach(string data in mySatack)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
