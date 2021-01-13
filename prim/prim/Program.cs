using System;

namespace prim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many prime numbers would you like to see?");
            int n = int.Parse(Console.ReadLine());
            MyMethod(n);
            Console.ReadLine();
        }

        static void MyMethod(int n)
        {
            int x= 0;
            int i;
            for (i=2; x<n; i++)
            {
                if (i == 2 || i == 3 || i == 5)
                {
                    Console.WriteLine(i);
                    x++;
                }
                if (i % 2 != 0 && i % 3 !=0 && i % 5 != 0) 
                {
                    Console.WriteLine(i);
                    x++;
                }
            }
        }
    }

}
