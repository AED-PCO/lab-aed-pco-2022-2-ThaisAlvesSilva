using System;

namespace selectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10000];
            int comparacoes = 0, trocas = 0;

            preencheVetor(vet);

            selectionSort(vet, ref comparacoes, ref trocas);

            Console.WriteLine("\n\nVetor ordenado - Selection-sort: ");
            imprimeVetor(vet);

            Console.WriteLine("\n\nComparações:{0}", comparacoes);
            Console.WriteLine("Trocas:{0}", trocas);
        }

        static void selectionSort(int[] vet, ref int comparacoes, ref int trocas){
            int posMenor, aux;

            for(int i=0; i<vet.Length; i++){
                posMenor = i;

                for(int j = i+1; j < vet.Length; j++){
                    comparacoes++;
                    if(vet[j] < vet[posMenor]){
                        posMenor = j;
                    }
                }

                comparacoes++;
                if(posMenor != i){
                    trocas++;
                    aux = vet[posMenor];
                    vet[posMenor] = vet[i];
                    vet[i] = aux;
                }

            }
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = randNum.Next(30);
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write(vet[i] + "\t");
            }
        }
    }
}
