using System;

namespace pilhaCopia
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pilha = new int[5];
            int[] pilhaCopia = new int[pilha.Length];
            int referencia = 0;
            int op = menuPrincipal(), num;

            while(op != 5){
                switch(op){
                    case 1:
                        if(referencia < pilha.Length){
                            Console.WriteLine("Qual valor deseja inserir na pilha?");
                            num = int.Parse(Console.ReadLine());
                            insereNapilha(pilha,referencia++,num);
                        }else
                            Console.WriteLine("pilha cheia. Remova um elemento antes de inserir");
                        sair();
                    break;
                    case 2:
                        int elementoRemovido = removeDapilha(pilha, referencia--);
                        sair();
                    break;
                    case 3:
                        Console.WriteLine("Elementos da pilha: ");
                        imprimepilha(pilha,referencia);            
                        sair();
                    break;
                    case 4:
                        copiaPilha(pilha, pilhaCopia, referencia);

                        Console.WriteLine("Elementos da pilha original: ");
                        imprimepilha(pilha,referencia);    
                                
                        Console.WriteLine("\nElementos da pilha cópia:");
                        imprimepilha(pilhaCopia,referencia);
                        sair();
                    break;

                }
                Console.Clear();
                op = menuPrincipal();
		    }    
        
        }

        static void copiaPilha(int[] pilha1, int[] pilha2, int referencia){
            int[] vetAux = new int[pilha1.Length];
            int refAux = referencia;
            int i = 0;

            for(i = 0; i < refAux; i++){
                vetAux[i] = removeDapilha(pilha1, referencia--);
            }
            
            i = refAux - 1;
            while(referencia < refAux){
                insereNapilha(pilha2,referencia,vetAux[i]);
                insereNapilha(pilha1,referencia,vetAux[i]);
                i--;
                referencia++;
            }

        }

        static void sair(){
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        static int menuPrincipal(){
            int op;
            Console.WriteLine("==============================");
            Console.WriteLine("|(1)INSERIR NA PILHA          |");
            Console.WriteLine("|(2)RETIRAR DA PILHA	      |");
            Console.WriteLine("|(3)MOSTRAR A PILHA	      |");
            Console.WriteLine("|(4)COPIAR PILHA	      |");
            Console.WriteLine("|(5)SAIR    		      |");
            Console.WriteLine("==============================");
            op = int.Parse(Console.ReadLine());
            return op;
	    }

        static void insereNapilha(int[] pilha, int referencia, int num){
            pilha[referencia] = num;
            Console.WriteLine("Valor inserido com sucesso!");
        }

        static int removeDapilha(int[]pilha, int referencia){
            return pilha[referencia-1];
        }

        static void imprimepilha(int[] pilha, int referencia){
            while(referencia >0){
                Console.Write("\t" + removeDapilha(pilha, referencia--));
            }
        }
    }
}

