using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite o número que deseja calcular o fatorial:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Fatorial de {0} = {1}", num,fatorial(num));
        }

        static int fatorial(int num){
            if(num == 2){
                return 2;
            }

            return num * fatorial(num -1); 
        }
    }
}
