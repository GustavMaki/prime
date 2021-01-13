using System;

namespace prim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many prime numbers would you like to see?");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            PrimeNum(n);
            Console.ReadLine();
        }

        static bool PrimeTest(double test)
        {
            if (test == 1)
            {
                return false;
            }

            if (((test / 2) % 1 == 0) && test != 2)
            {
                return false;
            }

            double root = Math.Sqrt(test);
            int interval = Convert.ToInt32(Math.Floor(root));

            for (int i = 3; i <= interval; i++)
            {
                if ((test / i) % 1 == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void PrimeNum(int n)
        {
            int i = 1;
            int count = 0;

            do
            {
                if (PrimeTest(i))
                {
                    Console.WriteLine(i);
                    count++;
                }

                i ++;
            } while (count < n);
        }
    }
}
