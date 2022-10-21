using System;

namespace Questão4
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] cpf = new long[10];

            for(int i = 0; i < cpf.Length; i++){
                cpf[i] = geraCPF();
            }

            mergeSort(cpf, 0, cpf.Length - 1);

            for(int i = 0; i < cpf.Length; i++){
                Console.WriteLine("CPF:{0}",cpf[i]);
            }        
        }

        static long geraCPF(){
            Random randNum = new Random();
            string digitos = randNum.Next(9).ToString();
            int soma = 0, i,j;

            for(i = 1, j = 10; i<9; i++, j--){
                digitos += randNum.Next(9).ToString();
                soma += int.Parse(digitos[i].ToString()) * j;
                
            }
            digitos += digitoVerificador(soma);

            soma = 0;

            for(i = 1, j = 10; i<10; i++, j--){
                soma += int.Parse(digitos[i].ToString()) * j;
            }

            soma = digitoVerificador(soma);
            //Console.WriteLine("SOMA:{0}",soma);
            digitos += soma;

            //Console.WriteLine("CPF:{0}",digitos);

            long cpf = long.Parse(digitos);
            //Console.WriteLine("CPF:{0}",digitos);
            return cpf;
        }

        static int digitoVerificador(int soma){
            if((soma % 11) == 0 || (soma % 11) == 1){
                return 0;
            }else{
                return 11 - (soma % 11);
            }
        }

        static void mergeSort(long[] vet, int inicio, int fim){
            if(inicio < fim){
                int meio = inicio + (fim - inicio) / 2;
                mergeSort(vet, inicio, meio);
                mergeSort(vet, meio + 1, fim);
                intercalar(vet, inicio, fim);
            }
        }

        static void intercalar(long[] vet, int inicio, int fim){
            int meio = (inicio + fim) / 2;
            int k = inicio, i,j;

            long[] vetAux1 = new long[meio + 1];
            long[] vetAux2 = new long[fim - meio];

            for (i = 0; i < (meio - inicio) + 1; i++) 
                vetAux1[i] = vet[inicio + i];
            for (j = 0; j < fim - meio; j++) 
                vetAux2[j] = vet[meio + 1 + j];

            for (i = 0, j = 0;i < (meio - inicio) + 1 && j < fim - meio; k++){
                if (vetAux1[i] <= vetAux2[j]){
                    vet[k] = vetAux1[i];
                    i++;
                }else{
                    vet[k] = vetAux2[j];
                    j++;
                }
            }
            for (;i < (meio - inicio) + 1; i++, k++) 
                vet[k] = vetAux1[i];
            for (;j < fim - meio; j++, k++) 
                vet[k] = vetAux2[j];
        }
    }
}
