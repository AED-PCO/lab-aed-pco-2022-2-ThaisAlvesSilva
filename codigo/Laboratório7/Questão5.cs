using System;

namespace Questão5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[]{10,5,7,15,22,9,30};
            Console.WriteLine("Resultado:{0}", funcao(6,vet));
        }

        static int funcao(int a, int[] v){
            if(a == 1)
                return v[0];
            else{
                int x;
                x = funcao(a-1, v);
                if(x > v[a-1])
                    return x;
                else
                    return v[a-1];
            }
        }
    }
}
