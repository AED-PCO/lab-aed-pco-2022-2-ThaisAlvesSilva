using System;

namespace frase
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            char letra;

            Console.WriteLine("Digite a frase:");
            frase = Console.ReadLine();

            Console.WriteLine("Digite a letra que deseja procurar:");
            letra = Console.ReadKey().KeyChar;

            frase = frase.ToLower();
            letra = char.ToLower(letra);

            Console.WriteLine($"\n\nQuantidade de vezes que a letra '{letra}' ou '{char.ToUpper(letra)}' aparece na frase: {contaOcorrencia(frase,letra)} ");
        }

        static int contaOcorrencia(string frase, char letra){
            if(frase.Length == 0)
                return 0;

            if(frase[frase.Length - 1] == letra){
                return 1 + contaOcorrencia(frase.Substring(0,frase.Length - 1), letra);
            }else{
                return contaOcorrencia(frase.Substring(0,frase.Length - 1), letra);
            }
        }  
    }
}
