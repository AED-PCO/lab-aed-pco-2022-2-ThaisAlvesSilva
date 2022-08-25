using System;

namespace somaVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            preencheVetor(vet);

            Console.WriteLine("Valores do Vetor:");
            imprimeVetor(vet);
            
            Console.WriteLine("\n\nSoma dos números pares do vetor: {0}", somaPares(vet,vet.Length-1));
            
        }


        static int somaPares(int[] vet, int pos){
            if(pos == -1)
                return 0;

            if(vet[pos] % 2 == 0)
                return vet[pos] + somaPares(vet,pos-1);

            return somaPares(vet,pos-1);
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = randNum.Next(10);
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write("\t" + vet[i]);
            }
        }
    }
}
