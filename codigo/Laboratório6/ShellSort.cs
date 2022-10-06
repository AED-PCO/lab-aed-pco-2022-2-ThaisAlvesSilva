using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[1000];
            int comparacoes = 0, trocas = 0;

            preencheVetor(vet);

            Console.WriteLine("Valores do vetor:");
            imprimeVetor(vet);


            shellSort(vet, ref comparacoes, ref trocas);

            Console.WriteLine("\nVetor ordenado - shellSort:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nComparações:{0}", comparacoes);
            Console.WriteLine("Trocas:{0}", trocas);
            
        }

        static void shellSort(int[] vet, ref int comparacoes, ref int trocas){

            int h = 8, i, j, aux;
            while(h > 0){
                h = h / 2;
                for(i = 0; (i+h)<=vet.Length; i++){
                    for(j = i; (j-h)>=0; j-=h){
                        comparacoes++;
                        if(vet[j] <= vet[j-h]){
                            aux = vet[j];
                            vet[j] = vet[j-h];
                            vet[j-h] = aux;

                            trocas++;
                        }
                    }
                }

                if(h == 1){
                    h--;
                }
                
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
