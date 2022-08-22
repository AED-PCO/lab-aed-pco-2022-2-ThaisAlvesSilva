using System;

namespace Exc2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nO número {0} {1}.", num, verificaPrimo(num) ? "é primo" : "não é primo");

            Console.WriteLine("\nNúmeros perfeitos de 1 a 1000: ");
            for(int i = 1; i < 1000; i++){
                verificaPerfeito(i);
            }
        }

        static bool verificaPrimo(int num){
            for(int i = 2; i < num; i++){
                if(num % i == 0)
                    return false;   //NÃO É PRIMO
            }
            return true;
        }

        static void verificaPerfeito(int num){
            int soma = 0;
            for(int i = 1; i < num; i++){
                if(num % i == 0){
                    soma+= i;
                }
            }

            if(soma == num){
                Console.WriteLine(num);
            }
        }
    }
}
