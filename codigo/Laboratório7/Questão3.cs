using System;
using System.IO;

namespace Questão_3
{
    class Program
    {
        static void Main(string[] args){
            StreamReader sr = new StreamReader("entrada.txt");
            string textoArq = sr.ReadLine();

            sr.Close();

            StreamWriter sw = new StreamWriter("saida.txt");
            sw.WriteLine(inverte(textoArq, textoArq.Length -1));
            Console.WriteLine("Frase invertida com sucesso!");
            sw.Close();

        }

        static string inverte(string frase, int pos){
            if(pos == 0)
                return frase[pos] + "";
            
            return frase[pos] + inverte(frase, pos - 1);
        }
    }
}
