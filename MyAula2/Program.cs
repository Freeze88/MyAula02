using System;

namespace MyAula2
{
    class Program
    {
        static void Main()
        {
            double xx = 1.2345;
            int ii = 18;

            string x = $"{xx:f2}";
            string x2 = $"{xx:p1}";



            //string b = String.Format("inteiro fica {0:d}",xx);

            Console.WriteLine("{0} {1}", x, x2);
            
            Console.ReadKey();
        }
    }
}
