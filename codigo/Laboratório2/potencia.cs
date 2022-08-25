using System;

namespace potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Digite o valor de A(base): ");
            A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B(expoente): ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine("\n{0} elevado a {1} = {2}", A,B, potencia(A,B));
        }

        static int potencia(int A,int B){
            if(B == 1)
                return A;
            return A * potencia(A,B-1);
        }
    }
}
