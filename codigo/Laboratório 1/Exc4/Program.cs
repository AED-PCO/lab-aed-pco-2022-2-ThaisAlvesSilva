using System;

namespace Exc4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5,3];

            preencheMatriz(mat);

            Console.WriteLine("Matriz: ");
            imprimeMatriz(mat);

            Console.WriteLine("\nSoma das LINHAS da matriz:");
            somaLinhas(mat);
            Console.WriteLine("\nSoma das COLUNAS da matriz:");
            somaColunas(mat);
        }

        static void preencheMatriz(int[,] mat){
            Random randNum = new Random();
            for(int i = 0; i < mat.GetLength(0); i++){
                for(int j = 0; j < mat.GetLength(1); j++){
                    mat[i,j] = randNum.Next(50);
                }
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

        static void somaLinhas(int[,] mat){
            int soma = 0;
            for(int i = 0; i < mat.GetLength(0); i++){
                for(int j = 0; j < mat.GetLength(1);j++){
                    soma+= mat[i,j];
                }
                Console.WriteLine("Soma linha {0}: {1}", i, soma);
                soma = 0;
            }
        }

        static void somaColunas(int[,] mat){
            int soma = 0;
            for(int i = 0; i < mat.GetLength(1); i++){
                for(int j = 0; j < mat.GetLength(0);j++){
                    soma+= mat[j,i];
                }
                Console.WriteLine("Soma coluna {0}: {1}", i, soma);
                soma = 0;
            }
        }
    }
}
