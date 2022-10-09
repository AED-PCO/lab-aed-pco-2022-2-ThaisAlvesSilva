using System;

namespace QuickSort
{
    class Program
    {
        static int comparacoes = 0, trocas = 0;
        static void Main(string[] args)
        {
            int[] vet = new int[1000];

            preencheVetor(vet);

            quickSort(vet, 0, vet.Length -1);

            Console.WriteLine("\nVetor ordenado - MergeSort:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nComparações:{0}", comparacoes);
            Console.WriteLine("Trocas:{0}", trocas);
        }

        static void quickSort(int[] vet, int inicio, int fim){
            int i = inicio, j = fim;
            int x, y;
            x = vet[(inicio + fim) / 2];

            while(i <= j) {
                while(vet[i] < x && i < fim) {
                    i++;
                    comparacoes++;
                }
                while(vet[j] > x && j > inicio) {
                    j--;
                    comparacoes++;
                }
                if(i <= j) {
                    y = vet[i];
                    vet[i] = vet[j];
                    vet[j] = y;
                    i++;
                    j--;
                    trocas++;
                }
            }

            if(j > inicio) {
                quickSort(vet, inicio, j);
            }
            if(i < fim) {
                quickSort(vet, i, fim);
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
                Console.Write("\t" + vet[i]);
            }
        }
    }
}
