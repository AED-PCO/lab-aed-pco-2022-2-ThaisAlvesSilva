using System;

namespace fraseVogal
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            
            Console.WriteLine("Digite a frase:");
            frase = Console.ReadLine();

            Console.WriteLine("\nFrase sem vogal: ");
            retiraVogal(frase);
        }

        static void retiraVogal(string frase){
            if(frase.Length -1 == -1)
                return ;

            char letra = char.ToLower(frase[frase.Length - 1]);
            
            if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'){
                retiraVogal(frase.Substring(0,frase.Length - 1));
            }else{
                retiraVogal(frase.Substring(0,frase.Length - 1));
                Console.Write(frase[frase.Length - 1]);
            }    
        }  
    }
}
