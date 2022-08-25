using System;

namespace Exc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números:");
            for(int i = 1000; i<9999; i++){
                verificaNumero(i);
            }
        }

        static void verificaNumero(int num){
            int n1 =  int.Parse(num.ToString().Substring(0,2));     //COMEÇA NO INDEX 0 E VAI ATÉ O INDEX 2
            int n2 =  int.Parse(num.ToString().Substring(2));       //COMEÇA NO INDEX 2 E PEGA DESSE INDICE PARA FRENTE
            
            if(Math.Pow((n1 + n2), 2) == num){
                Console.WriteLine(num);
            }
        }
    }
}
