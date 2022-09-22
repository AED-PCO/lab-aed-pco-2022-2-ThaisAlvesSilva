using System;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            preencheVetor(vet);

            Console.WriteLine("\nVetor sem ordenar: ");
            imprimeVetor(vet);

            insertionSort(vet);

            Console.WriteLine("\n\nVetor ordenado - Insertion-sort: ");
            imprimeVetor(vet);

        }

        static void insertionSort(int[] vet){
            int i, j, referencia;

            for(i = 1; i< vet.Length; i++){
                referencia = vet[i];

                for(j = i; (j>0) && (vet[j-1] > referencia); j--){
                    vet[j] = vet[j-1];
                }

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
