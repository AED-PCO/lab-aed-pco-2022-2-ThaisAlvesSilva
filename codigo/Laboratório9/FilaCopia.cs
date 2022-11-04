using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] fila = new int[5];
            int[] filaCopia = new int[fila.Length];
            int referencia = 0;
            int op = menuPrincipal(), num;



            while(op != 5){
                switch(op){
                    case 1:
                        if(referencia < fila.Length){
                            Console.WriteLine("Qual valor deseja inserir na fila?");
                            num = int.Parse(Console.ReadLine());
                            insereNaFila(fila,referencia++,num);
                        }else
                            Console.WriteLine("Fila cheia. Remova um elemento antes de inserir");
                        sair();
                    break;
                    case 2:
                        if(referencia == 0)
                            Console.WriteLine("Não há elementos para serem retirados!");
                        else{
                            int elementoRemovido = removeDaFila(fila, referencia--);
                        }
                        sair();
                    break;
                    case 3:
                        Console.WriteLine("Elementos da Fila: ");
                        fila = imprimeFila(fila,referencia);            
                        sair();
                    break;
                    case 4:
                        copiaFila(fila, filaCopia, referencia);

                        Console.WriteLine("Elementos da fila original: ");
                        imprimeFila(fila,referencia);    
                                
                        Console.WriteLine("\nElementos da fila cópia:");
                        imprimeFila(filaCopia,referencia);
                        sair();

                    break;
                }
                Console.Clear();
                op = menuPrincipal();
		    }
            
        }

        static void copiaFila(int[] fila1, int[] fila2, int referencia){
            int[] vetAux = new int[fila1.Length];
            int refAux = referencia;
            int i = 0;

            for(i = 0; i < refAux; i++){
                vetAux[i] = removeDaFila(fila1, referencia--);
            }
            
            i = 0;

            while(referencia < refAux){
                insereNaFila(fila1,referencia++,vetAux[i++]);
            }

            i = referencia - 1;
            refAux = 0;
            while(refAux < referencia){
                insereNaFila(fila2,refAux++,vetAux[i--]);
            }

        }

        static void sair(){
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        static int menuPrincipal(){
            int op;
            Console.WriteLine("==============================");
            Console.WriteLine("|(1)INSERIR NA FILA           |");
            Console.WriteLine("|(2)RETIRAR DA FILA	      |");
            Console.WriteLine("|(3)MOSTRAR A FILA	      |");
            Console.WriteLine("|(4)COPIAR A FILA    	      |");
            Console.WriteLine("|(5)SAIR    		      |");
            Console.WriteLine("==============================");
            op = int.Parse(Console.ReadLine());
            return op;
	    }

        static void insereNaFila(int[] fila, int referencia, int num){
            fila[referencia] = num;
            //Console.WriteLine("Valor inserido com sucesso!");
        }

        static int removeDaFila(int[]fila, int referencia){
            int aux = fila[0];

            if(referencia >= fila.Length)
                referencia--;

            for(int i=1; i<=referencia; i++){
                fila[i-1] = fila[i];
            }
            return aux;
        }

        static int[] imprimeFila(int[] fila, int referencia){
            int[] filaAux = new int[fila.Length];
            int numRetirado, pos = 0;
            int aux = referencia;
            
            referencia--;
            while(referencia >=0){
                numRetirado = removeDaFila(fila, referencia--);
                Console.Write("\t" + numRetirado);
                filaAux[pos++] = numRetirado;
            }
            return filaAux; 
        }
    }
}


