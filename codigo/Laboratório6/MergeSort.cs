using System;

namespace MergeSort
{
    class Program
    {
        static int comparacoes = 0, trocas = 0;
        static void Main(string[] args)
        {
            int[] vet = new int[1000];

            preencheVetor(vet);

            mergeSort(vet, 0,vet.Length -1);

            Console.WriteLine("\nVetor ordenado - MergeSort:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nComparações:{0}", comparacoes);
            Console.WriteLine("Trocas:{0}", trocas);
        }

        static void mergeSort(int[] vet, int inicio, int fim){
            if(inicio < fim){
                int meio = inicio + (fim - inicio) / 2;
                mergeSort(vet, inicio, meio);
                mergeSort(vet, meio + 1, fim);
                intercalar(vet, inicio, fim);
            }
        }

        static void intercalar(int[] vet, int inicio, int fim){
            int meio = (inicio + fim) / 2;
            int k = inicio, i,j;

            int[] vetAux1 = new int[meio + 1];
            int[] vetAux2 = new int[fim - meio];

            for (i = 0; i < (meio - inicio) + 1; i++) 
                vetAux1[i] = vet[inicio + i];
            for (j = 0; j < fim - meio; j++) 
                vetAux2[j] = vet[meio + 1 + j];

            for (i = 0, j = 0;i < (meio - inicio) + 1 && j < fim - meio; k++){
                comparacoes++;
                if (vetAux1[i] <= vetAux2[j]){
                    trocas++;
                    vet[k] = vetAux1[i];
                    i++;
                }else{
                    trocas++;
                    vet[k] = vetAux2[j];
                    j++;
                }
            }
            for (;i < (meio - inicio) + 1; i++, k++) 
                vet[k] = vetAux1[i];
            for (;j < fim - meio; j++, k++) 
                vet[k] = vetAux2[j];
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
