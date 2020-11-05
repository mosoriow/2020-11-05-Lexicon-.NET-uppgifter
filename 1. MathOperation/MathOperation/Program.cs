using System;

namespace MathOperation
{
    class MathOperations
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public double Add(double x, double y, double z)
        {
            return x + y + z;
        }
        public decimal Add(decimal x, decimal y, decimal z)
        {
            return x + y + z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mo = new MathOperations();
            Console.WriteLine(mo.Add(2, 3));
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));

            Console.ReadKey();
        }
    }
}
