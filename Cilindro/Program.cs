using System;

namespace Cilindro
{
    class Program
    {
        static void Main()
        {
            string height, radius;
            float pi = 3.1415926f;

            Console.WriteLine("insira a altura do cílindro");
            height = Console.ReadLine();
            float h = Convert.ToInt32(height);

            Console.WriteLine("insira a área do cílindro");
            radius = Console.ReadLine();
            float r = Convert.ToInt32(radius);

            float Volume = pi*(r*r)*h;
            float Area = 2 * pi * r * (r + h);
            
            Console.WriteLine($"O volume do cílindro é : {Volume:f2} \nA área do cílindro é : {Area:f2}");

            Console.ReadKey();
        }

    }
}
