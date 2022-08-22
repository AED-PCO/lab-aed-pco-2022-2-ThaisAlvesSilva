using System;

namespace Exc5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite o número que deseja calcular o fatorial: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Fatorial de {0} = {1}", num, calculaFatorial(num));
        }

        static int calculaFatorial(int num){
            int fatorial = num;
            for(int i = num-1; i>0; i--){
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
