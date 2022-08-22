using System;

namespace Exc6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double result = 0;

            Console.Write("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            calcula(x, y, ref result);
            Console.WriteLine("\n{0} elevado a {1} = {2}", x, y, result);

        }

        static void calcula(int x, int y, ref double result){
            result = Math.Pow(x,y);
        }
    }
}
