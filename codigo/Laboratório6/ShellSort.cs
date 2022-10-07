using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int comparacoes = 0, trocas = 0;

            preencheVetor(vet);

            shellSort(vet, ref comparacoes, ref trocas);

            Console.WriteLine("\nVetor ordenado - shellSort:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nComparações:{0}", comparacoes);
            Console.WriteLine("Trocas:{0}", trocas);
            
        }

        static void shellSort(int[] vet, ref int comparacoes, ref int trocas){

            int h = 4, i, j, referencia;
            while(h > 0){
                for(i = 0; (i+h)<=(vet.Length -1); i++){
                    referencia = vet[i+h];
                    comparacoes++;
                    for(j=i+h; (j-h>=0) && vet[j-h] >= referencia; j-=h){
                        vet[j] = vet[j-h];
                        trocas++;
                    }
                    vet[j] = referencia;
                     
                }
                h = h / 2;
                
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
