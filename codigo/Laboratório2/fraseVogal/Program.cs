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

            Console.WriteLine("\nFrase sem vogal:\n" + retiraVogal(frase));
        }

        static string retiraVogal(string frase){
            if(frase == "")
                return "";

            char letra = char.ToLower(frase[frase.Length - 1]);
            
            if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u'){
                return retiraVogal(frase.Substring(0,frase.Length - 1));
            }else{
                return retiraVogal(frase.Substring(0,frase.Length - 1)) + frase[frase.Length - 1];
            }    
        }    
    }
}
