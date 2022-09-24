using System;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int comparacoes = 0, trocas = 0;

            preencheVetor(vet);

            Console.WriteLine("Valores do Vetor:");
            imprimeVetor(vet);

            bubblesort(vet, ref comparacoes, ref trocas);

            Console.WriteLine("\n\n Vetor Ordenado:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nComparações:{0}", comparacoes);
            Console.WriteLine("Trocas:{0}", trocas);
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

        static void bubblesort(int[] vet, ref int comparacoes, ref int troca){

            int j, aux;

            for(int i = vet.Length - 1; i > 0 ; i--){
                for(j = 0; j<vet.Length - 1; j++){
                    comparacoes++;
                    if(vet[j+1] <= vet[j]){
                        troca++;
                        aux = vet[j+1];
                        vet[j+1] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
        }
    }
}
