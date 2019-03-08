using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string height;
            string radius;

            Console.WriteLine("insira a altura do cílindro");
            height = Console.ReadLine();
            radius = Console.ReadLine();

            
            Console.WriteLine("{0} e {1}", height, radius);

            Console.ReadKey();
        }
    }
}
