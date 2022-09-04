using System;

namespace Exc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int comparacoes = 0, atribuicoes = 0, soma = 0;
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];
            int[] D = new int[10];
            int i;

            for(i = 0; i < 10; i++){
                A[i] = randNum.Next(1,100);
                atribuicoes++;
            }
            for(i = 0; i < 10; i++){
                B[i] = randNum.Next(1,100);
                atribuicoes++;
            }


            Console.WriteLine("Vetor A:");
            imprimeVetor(A);
            Console.WriteLine("\nVetor B:");
            imprimeVetor(B);

            intersercao(A, B,C, ref comparacoes, ref atribuicoes, ref soma);
            Console.WriteLine("\n\nInterseção entre A e B:");
            for(i=0; i<C.Length; i++){
                comparacoes++;
                if(C[i] != 0){
                    Console.Write("\t" + C[i]);
                }
                
            }

            diferenca(A, B,D, ref comparacoes, ref atribuicoes, ref soma);
            Console.WriteLine("\n\nElementos de A que não existem em B:");
            for(i=0; i<D.Length; i++){
                comparacoes++;
                if(D[i] != 0){
                    Console.Write("\t" + D[i]);
                }
                
            }

            Console.WriteLine("\nComparações:{0}", comparacoes);
            Console.WriteLine("Atribuições:{0}", atribuicoes);
            Console.WriteLine("soma:{0}", soma);
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

        static void intersercao(int[] A, int[] B, int[] C, ref int comparacoes, ref int atribuicoes, ref int soma){
            int posC = 0;
            bool igual = false;
            for(int i=0; i<A.Length; i++,soma++){
                for(int j=0; j<B.Length; j++,soma++){
                    comparacoes++;
                    if(A[i] == B[j]){
                        igual = true;
                        atribuicoes++;
                    }
                } 

                comparacoes++;
                if(igual){
                    comparacoes++;
                    if(!verificaArray(C,A[i], ref comparacoes, ref soma)){
                        atribuicoes++;
                        C[posC++] = A[i];
                        soma++;
                    }
                }
                igual = false;
                atribuicoes++;
            }
        }

        static void diferenca(int[] A, int[] B, int[] D, ref int comparacoes, ref int atribuicoes, ref int soma){
            int posD = 0;
            bool igual = false;
            for(int i=0; i<A.Length; i++, soma++){
                for(int j=0; j<B.Length; j++,soma++){
                    comparacoes++;
                    if(A[i] == B[j]){
                        igual = true;
                        atribuicoes++;
                    }
                }
                comparacoes++;
                if(!igual){
                    comparacoes++;
                    if(!verificaArray(D,A[i], ref comparacoes, ref soma))
                        D[posD++] = A[i];
                        soma++;
                        atribuicoes++;
                    
                }
                igual = false;
                atribuicoes++;
            }
        }

        static bool verificaArray(int[] vet, int num, ref int comparacoes, ref int soma){
            for(int i =0; i<vet.Length; i++, soma++){
                comparacoes++;
                if(vet[i] == num)   
                    return true;
            }
            return false;
        }
    }
}
