using System;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resultado:{0}", funcRec1(1));
        }

        static int funcRec1(int a){
            if(a>=3002)
                return 0;
            else 
                return funcRec1((a-2) +5);
        }
    }
}
