using System;

namespace buscaBinariaRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int num,pos;
            int comparacoes = 0, atribuicoes = 0, soma = 0;

            preencheVetor(vet);

            Console.WriteLine("Valores do Vetor:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nDigite o valor que deseja buscar no vetor:");
            num = int.Parse(Console.ReadLine());

            pos = buscaBinariaRecursiva(vet,num,0, (vet.Length -1), ref soma, ref comparacoes);

            if(pos != -1)
                Console.WriteLine($"O número {num} está na posição {pos} do vetor.");
            else{
               Console.WriteLine($"O número {num} não está no vetor na posição {pos}."); 
            }

            Console.WriteLine("Comparações:{0}", comparacoes);
            Console.WriteLine("Atribuições:{0}", atribuicoes);
            Console.WriteLine("soma:{0}", soma);
        }

        static int buscaBinariaRecursiva(int[] vet, int num, int posInicial,int posFinal, ref int soma, ref int comparacoes){
            comparacoes++;
            if(posFinal < posInicial)
                return -1;      //NUMERO NÃO EXISTE NO VETOR
            
            int posMeio = (posFinal + posInicial) / 2;
            soma++;
            comparacoes+= 2;
            if(vet[posMeio] < num){
                comparacoes--;
                return  buscaBinariaRecursiva(vet,num,(posMeio + 1), posFinal, ref soma, ref comparacoes);
            }else if(vet[posMeio] > num){
                return  buscaBinariaRecursiva(vet,num, posInicial,(posMeio - 1),ref soma, ref comparacoes);
            }
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
