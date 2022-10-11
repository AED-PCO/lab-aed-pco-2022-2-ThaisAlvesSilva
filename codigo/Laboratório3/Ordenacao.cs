using System;

namespace ordenação_e_buscaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];

            preencheVetor(vet);

            Console.WriteLine("Valores do Vetor:");
            imprimeVetor(vet);

            ordenacaoBinaria(vet,0, vet.Length -1);

            Console.WriteLine("\nVetor ordenado:");
            imprimeVetor(vet);

        }

        static void ordenacaoBinaria(int[] vetor, int posInicial, int tam)
        {
            if (posInicial < tam)
            {
                int meio = posInicial + (tam - posInicial) / 2;
                ordenacaoBinaria(vetor, posInicial, meio);
                ordenacaoBinaria(vetor, meio + 1, tam);
                ordenaVetor(vetor, posInicial, meio, tam);
            }
        }
        static void ordenaVetor(int[] vet, int posInicial, int meio, int tam)
        {
            int[] vet1 = new int[(meio - posInicial) + 1];
            int[] vet2 = new int[tam - meio];

            int i, j, k;

            for (i = 0; i < meio - posInicial + 1; i++) 
                vet1[i] = vet[posInicial + i];
            for (j = 0; j < tam - meio; j++) 
                vet2[j] = vet[meio + 1 + j];
            k = posInicial;
            for (i = 0, j = 0;i < meio - posInicial + 1 && j < tam - meio; k++){
                if (vet1[i] <= vet2[j]){
                    vet[k] = vet1[i];
                    i++;
                }
                else{
                    vet[k] = vet2[j];
                    j++;
                }
            }
            for (i=i,k=k;i < meio - posInicial + 1; i++, k++) 
                vet[k] = vet1[i];
            for (j=j,k=k;j < tam - meio; j++, k++) 
                vet[k] = vet2[j];
        }

        static void preencheVetor(int[] vet){
            Random randNum = new Random();
            for(int i = 0; i < vet.Length; i++){
                vet[i] = randNum.Next(20);
            }
        }

        static void imprimeVetor(int[] vet){
            for(int i = 0; i < vet.Length; i++){
                Console.Write("\t" + vet[i]);
            }
        }
    }
}
