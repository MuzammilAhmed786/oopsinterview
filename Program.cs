using System;

namespace jfk
{
    class Program
    {
        static void Main(string[] args)
        {
            first f = new first();
            Console.WriteLine(first.hellothere(2));
            first.printone();

            first ff = new first();
            first.printone();
        }
    }

    class first 
    {
        public static int one = 1;
        public static string hellothere(int p)
        {
            one = p;
            return "Hello there" + p;
        }

        public static void printone()
        {
            Console.WriteLine(one);
        }


    }


    public class second
    {
       const int i = 0;
       readonly int b;

        int operation()
        {
           return 0;
        }

        

    }
    
}
