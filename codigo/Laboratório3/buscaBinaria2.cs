using System;

namespace buscaBinariaRecursivaSemPos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            int num,pos;

            preencheVetor(vet);

            Console.WriteLine("\nValores do vetor:");
            imprimeVetor(vet);

            Console.WriteLine("\n\nDigite o valor que deseja buscar no vetor:");
            num = int.Parse(Console.ReadLine());

            pos = buscaBinariaRecursivaSemPos(vet,num);

            if(pos != -1)
                Console.WriteLine($"O número {num} está no vetor.");
            else
               Console.WriteLine($"O número {num} não está no vetor."); 
        }

        static int buscaBinariaRecursivaSemPos(int[] vet, int num){  
            if(vet.Length == 0){
                return -1;         //NUMERO NÃO EXISTE NO VETOR
            }
            
            int posMeio = vet.Length / 2;

            if(vet[posMeio] < num){
                int[] vetAux = new int[vet.Length - (posMeio +1)];
                Array.Copy(vet, posMeio+1,vetAux,0,vet.Length - (posMeio+1));       
                
                return  buscaBinariaRecursivaSemPos(vetAux,num);
            }else if(vet[posMeio] > num){
                int[] vetAux = new int[posMeio];
                Array.Copy(vet,0,vetAux,0,posMeio);         // primeiro 0: vai pegar a partir da posição 0, posMeio: quantas posições vai pegar
                
                return  buscaBinariaRecursivaSemPos(vetAux,num);    
            }
            else
                return 1;
            
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = i+ 2;
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write("\t" + vet[i]);
            }
        }
    }
}
