using System;

namespace Exc6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            int comparacoes = 0, atribuicoes = 0, soma = 0;
            double result = 0;

            Console.Write("Digite o valor de x(base): ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de y(expoente): ");
            y = int.Parse(Console.ReadLine());
            atribuicoes +=2;

            calcula(x, y, ref result, ref atribuicoes);
            Console.WriteLine("\n{0} elevado a {1} = {2}", x, y, result);

            Console.WriteLine("Comparações:{0}", comparacoes);
            Console.WriteLine("Atribuições:{0}", atribuicoes);
            Console.WriteLine("soma:{0}", soma);

        }

        static void calcula(int x, int y, ref double result, ref int atribuicoes){
            result = Math.Pow(x,y);
            atribuicoes++;
        }
    }
}
