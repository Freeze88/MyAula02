using System;

namespace Nova_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            char letter = 'd';

            string message = "Olá Mundo";
            string message2 = @"\n";
            string message3 = @"""""""""""""""""""""""""it will be fun they said""""""""""""""""""""""""""""";
            string msg = "a" + 2;
            string msg2 = "abc" + letter;
            string msg3 = $"valor de x é {x}";
            string msg4 = $"{x} mais {y} é igual a {x + y}";

           

            Console.WriteLine(message);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
            Console.WriteLine(msg);
            Console.WriteLine(msg2);
            Console.WriteLine(msg3);
            Console.WriteLine(msg4);
            Console.ReadKey();
        }
    }
}
