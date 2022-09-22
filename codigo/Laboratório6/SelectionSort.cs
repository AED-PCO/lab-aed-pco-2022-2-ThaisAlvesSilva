using System;

namespace selectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            preencheVetor(vet);


            
            Console.WriteLine("\nVetor sem ordenar: ");
            imprimeVetor(vet);

            selectionSort(vet);

            Console.WriteLine("\n\nVetor ordenado - Selection-sort: ");
            imprimeVetor(vet);
        }

        static void selectionSort(int[] vet){
            int posMenor, aux;

            for(int i=0; i<vet.Length; i++){
                posMenor = i;

                for(int j = i+1; j < vet.Length; j++){
                    if(vet[j] < vet[posMenor]){
                        posMenor = j;
                    }
                }

                if(posMenor != i){
                    aux = vet[posMenor];
                    vet[posMenor] = vet[i];
                    vet[i] = aux;
                }

            }
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = randNum.Next(15);
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write(vet[i] + "\t");
            }
        }
    }
}
