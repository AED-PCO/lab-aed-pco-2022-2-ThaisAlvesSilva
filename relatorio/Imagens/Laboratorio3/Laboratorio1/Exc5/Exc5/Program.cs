using System;

namespace Exc5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int comparacoes = 0, atribuicoes = 0, soma = 0;

            Console.Write("Digite o número que deseja calcular o fatorial: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Fatorial de {0} = {1}", num, calculaFatorial(num, ref atribuicoes));

            Console.WriteLine("\nComparações:{0}", comparacoes);
            Console.WriteLine("Atribuições:{0}", atribuicoes);
            Console.WriteLine("soma:{0}", soma);


        }

        static int calculaFatorial(int num, ref int atribuicoes){
            int fatorial = num;
            atribuicoes++;
            for(int i = num-1; i>0; i--){
                atribuicoes++;
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
