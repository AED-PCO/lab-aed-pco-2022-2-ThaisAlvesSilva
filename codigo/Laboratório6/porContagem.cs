using System;

namespace Contagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[]{3,6,1,2,3,6,4,2,3,1};

            Console.WriteLine("Vetor: ");
            imprimeVetor(vet);

            contagem(vet);

            Console.WriteLine("\nVetor ordenado - por contagem: ");
            imprimeVetor(vet);
        }

        static void contagem(int[] vet){
            int max = vet[0], min = vet[0], i, j;
            getMinMax(vet,ref max, ref min);

            int[,] mat = new int[max - min + 1,3]; 

            //Console.WriteLine("\nMin:{0} - Max: {1}", min, max);
            Console.WriteLine("\n\n\tNº\tCont\tPos");

            for(i = 0, j = min; i<mat.GetLength(0); i++, j++){          // PREECHENDO A PRIMEIRA COLUNA
                mat[i,0] = j;        
            } 

            for(i = 0; i<vet.Length; i++){                              // PREENCHENDO A COLUNA DO CONT
                mat[vet[i] - 1,1]++;
            }

            for(i = 1; i<mat.GetLength(0); i++){
                mat[i,2] = mat[i-1, 1] +  mat[i-1, 2];                  // PREENCHENDO A COLUNA DO POS
            }

            imprimeMatriz(mat);
            insereValores(vet, mat);                                    //INSERINDO OS VALORES NO VETOR
        }

        static void insereValores(int[]vet, int[,] mat){
            int[] vetAux = new int[vet.Length];
            int i;
            for(i = 0; i <vet.Length; i++){
                vetAux[mat[vet[i] - 1, 2]] = vet[i];
                mat[vet[i] - 1, 2]++;
            }

            for(i = 0; i< vet.Length; i++){
                vet[i] = vetAux[i];
            }
        }

        static void imprimeMatriz(int[,] mat){
            for(int i = 0; i < mat.GetLength(0); i++){
                for(int j = 0; j < mat.GetLength(1); j++){
                    Console.Write("\t" + mat[i,j]);
                }
                Console.WriteLine("");
            }
        }

        static void getMinMax(int[] vet, ref int max, ref int min){
            for(int i = 0; i < vet.Length; i++){
                if(vet[i] > max){
                    max = vet[i];
                }
                if(vet[i] < min){
                    min = vet[i];
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
                Console.Write(vet[i] + "\t");
            }
        }
    }
}
