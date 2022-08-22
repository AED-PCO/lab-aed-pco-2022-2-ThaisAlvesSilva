using System;

namespace multiplicação
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2;

            Console.WriteLine("Digite os números que deseja multiplicar:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n{0} * {1} = {2}", n1, n2, multiplica(n1,n2));
        }

        static int multiplica(int n1, int n2){
            if(n2 == 1)
                return n1;

            return n1 + multiplica(n1,n2 - 1);
        }
    }
}
