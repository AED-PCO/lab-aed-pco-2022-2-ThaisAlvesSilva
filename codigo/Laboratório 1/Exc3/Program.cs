using System;

namespace Exc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[5];
            int[] D = new int[5];
            int i;

            for(i = 0; i < 5; i++){
                A[i] = randNum.Next(1,15);
            }
            for(i = 0; i < 5; i++){
                B[i] = randNum.Next(1,15);
            }

            Console.WriteLine("Vetor A:");
            imprimeVetor(A);
            Console.WriteLine("\nVetor B:");
            imprimeVetor(B);

            intersercao(A, B,C);
            Console.WriteLine("\n\nInterseção entre A e B:");
            for(i=0; i<C.Length; i++){
                if(C[i] != 0){
                    Console.Write("\t" + C[i]);
                }
                
            }

            diferenca(A, B,D);
            Console.WriteLine("\n\nElementos de A que não existem em B:");
            for(i=0; i<D.Length; i++){
                if(D[i] != 0){
                    Console.Write("\t" + D[i]);
                }
                
            }
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i=0; i<vet.Length; i++){
                vet[i] = randNum.Next(1,30);
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i=0; i<vet.Length; i++){
                Console.Write("\t" + vet[i]);
            }
        }

        static void intersercao(int[] A, int[] B, int[] C){
            int posC = 0;
            bool igual = false;
            for(int i=0; i<A.Length; i++){
                for(int j=0; j<B.Length; j++){
                    if(A[i] == B[j]){
                        igual = true;
                    }
                } 

                if(igual){
                    if(!verificaArray(C,A[i]))
                        C[posC++] = A[i];
                }
                igual = false;
            }
        }

        static void diferenca(int[] A, int[] B, int[] D){
            int posD = 0;
            bool igual = false;
            for(int i=0; i<A.Length; i++){
                for(int j=0; j<B.Length; j++){
                    if(A[i] == B[j]){
                        igual = true;
                    }
                }
                if(!igual){
                    if(!verificaArray(D,A[i]))
                        D[posD++] = A[i];
                    
                }
                igual = false;
            }
        }

        static bool verificaArray(int[] vet, int num){
            for(int i =0; i<vet.Length; i++){
                if(vet[i] == num)   
                    return true;
            }
            return false;
        }
    }
}
