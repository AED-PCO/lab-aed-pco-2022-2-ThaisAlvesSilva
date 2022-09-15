using System;

namespace buscaBinaria1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            int num,pos;

            preencheVetor(vet);

            Console.WriteLine("Valores do Vetor:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nDigite o valor que deseja buscar no vetor:");
            num = int.Parse(Console.ReadLine());

            pos = buscaBinariaRecursiva(vet,num,0, (vet.Length -1));

            if(pos != -1)
                Console.WriteLine($"O número {num} está na posição {pos} do vetor.");
            else
               Console.WriteLine($"O número {num} não está no vetor."); 
        }

        static int buscaBinariaRecursiva(int[] vet, int num, int posInicial,int posFinal){
            if(posFinal < posInicial)
                return -1;      //NUMERO NÃO EXISTE NO VETOR
            
            int posMeio = (posFinal + posInicial) / 2;
            if(vet[posMeio] < num)
                return  buscaBinariaRecursiva(vet,num,(posMeio + 1), posFinal);
            else if(vet[posMeio] > num)
                return  buscaBinariaRecursiva(vet,num, posInicial,(posMeio - 1));
            else
                return posMeio;
            
        }

        static void selectionSort(int[] vet){
            int min, aux;

            for(int i=0; i<vet.Length; i++){
                min = i;

                for(int j = i+1; j < vet.Length; j++){
                    if(vet[j] < vet[min]){
                        min = j;
                    }
                }

                if(min != i){
                    aux = vet[min];
                    vet[min] = vet[i];
                    vet[i] = aux;
                }
            }
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = i+2;
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write("\t" + vet[i]);
            }
        }
    }
}
