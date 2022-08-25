using System;

namespace multiplicação
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2, result;

            Console.WriteLine("Digite os números que deseja multiplicar:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

        
            Console.Write("\n{0} * {1} = ", n1, n2);
            result = multiplica(n1,Math.Abs(n2));

            if(n1 < 0 && n2 < 0)
                result *= -1;
            else if(n2 < 0)
                result *= -1;
            Console.Write(result);
            
        }

        static int multiplica(int n1, int n2){
            if(n2 == 1)
                return n1;
            return n1 + multiplica(n1,n2 - 1);
        }
    }
}
