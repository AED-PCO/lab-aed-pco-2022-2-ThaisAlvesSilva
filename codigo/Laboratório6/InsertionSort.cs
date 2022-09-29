using System;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10000];
            int comparacoes = 0, trocas = 0;
            preencheVetor(vet);

            insertionSort(vet, ref comparacoes, ref trocas);

            Console.WriteLine("\n\nVetor ordenado - Insertion-sort: ");
            imprimeVetor(vet);

            Console.WriteLine("\n\nComparações:{0}", comparacoes);
            Console.WriteLine("Trocas:{0}", trocas);

        }

        static void insertionSort(int[] vet, ref int comparacoes, ref int trocas){
            int i, j, referencia;

            for(i = 1; i< vet.Length; i++){
                referencia = vet[i];

                for(j = i; (j>0) && (vet[j-1] > referencia); j--, comparacoes++){
                    trocas++;
                    vet[j] = vet[j-1];
                }

                trocas++;
                vet[j] = referencia;
            }
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = randNum.Next(20);
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write(vet[i] + "\t");
            }
        }
    }
}
