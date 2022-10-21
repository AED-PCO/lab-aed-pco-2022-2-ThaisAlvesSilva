using System;
using System.IO;

namespace Questão_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            int iguais = 0, diferentes = 0;

            Console.WriteLine("Digite o texto que deseja procurar no arquivo:");
            texto = Console.ReadLine();

            procuraTexto(ref iguais, ref diferentes, texto);

            Console.WriteLine("Qauntidade de termos iguais:{0}", iguais);
            Console.WriteLine("Qauntidade de termos diferentes:{0}", diferentes);

        }

        static void procuraTexto(ref int iguais, ref int diferentes, string frase){
            StreamReader sr = new StreamReader("arq1.txt");
            string linha = sr.ReadLine(); 


            while(linha != null){
                String []textoArq = linha.Split(" ");
                for(int i = 0; i < textoArq.Length; i++){
                    Console.WriteLine(textoArq[i]);
                    if(textoArq[i] == frase)
                        iguais++;
                    else
                        diferentes++;
                }
                linha = sr.ReadLine();
            }
            sr.Close();

        }
    }
}
