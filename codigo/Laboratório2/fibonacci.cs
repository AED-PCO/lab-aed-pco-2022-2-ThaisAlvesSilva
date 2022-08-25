using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite a posição da sequencia Fibonacci que deseja saber o valor:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"O {num}º número da sequencia de Fibonacci é o: {fib(num)}");
        }

        static int fib(int x){
            if( x == 1)
                return 0;
            if( x == 2)
                return 1;

            return fib(x-1) + fib(x -2);
        }
    }
}
