using System;

namespace listaEstática
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] lista = new int[3];
            int referencia = 0;
            int op = menuPrincipal(), num, pos;
            char resposta;

            while(op != 4){
                switch(op){
                    case 1:
                        if(referencia < lista.Length){
                            pos = -1;
                            Console.WriteLine("Deseja escolher uma posição para adicionar (s)im ou (n)ão?");
                            resposta = char.Parse(Console.ReadLine());
                            if(resposta == 's' || resposta == 'S'){
                                Console.WriteLine("Em qual posição deseja inserir o valor?");
                                pos = int.Parse(Console.ReadLine());
                            }else{
                                pos = referencia;
                            }
                            Console.WriteLine("Qual valor deseja inserir na lista?");
                            num = int.Parse(Console.ReadLine());
                            insereNalista(lista,referencia++,pos, num);
                        }else
                            Console.WriteLine("lista cheia. Remova um elemento antes de inserir");
                        sair();
                    break;
                    case 2:
                        pos = -1;
                        if(referencia == 0)
                            Console.WriteLine("Não há elementos para serem retirados!");
                        else{
                            Console.WriteLine("Em qual posição deseja remover o valor?");
                            pos = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if(pos <= referencia){
                                int elementoRemovido = removeDalista(lista, pos, referencia--);
                            }else{
                                Console.WriteLine("Posição inválida!");
                            } 
                        }
                        sair();
                    break;
                    case 3:
                        Console.WriteLine("Elementos da lista: ");
                        lista = imprimelista(lista,referencia);            
                        sair();
                    break;
                }
                Console.Clear();
                op = menuPrincipal();
		    }
        }

        static void sair(){
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

        static int menuPrincipal(){
            int op;
            Console.WriteLine("==============================");
            Console.WriteLine("|(1)INSERIR NA LISTA          |");
            Console.WriteLine("|(2)RETIRAR DA LISTA	      |");
            Console.WriteLine("|(3)MOSTRAR A LISTA	      |");
            Console.WriteLine("|(4)SAIR    		      |");
            Console.WriteLine("==============================");
            op = int.Parse(Console.ReadLine());
            return op;
	    }

        static void insereNalista(int[] lista, int referencia,int pos,int num){
            if(pos >= referencia){
                lista[referencia] = num;
            }else if(pos != -1){
                for(int i = referencia; i>pos; i--){
                    lista[i] = lista[i-1];
                }
                lista[pos] = num;
            }else{
                
            }
            Console.WriteLine("Valor inserido com sucesso!"); 
        }

        static int removeDalista(int[]lista, int pos, int referencia){
            int aux;

            if(referencia >= lista.Length)
                referencia--;

            if(pos == -1){
                aux = lista[0];
                for(int i=1; i<=referencia; i++){
                    lista[i-1] = lista[i];
                }   
            }else{
                aux = lista[pos];
                for(int i = pos; (i+1)<=referencia; i++){
                    lista[i] = lista[i+1];
                }
            }
            
            return aux;
        }

        static int[] imprimelista(int[] lista, int referencia){
            int[] listaAux = new int[lista.Length];
            int numRetirado, pos = 0;
            int aux = referencia;
            
            referencia--;
            while(referencia >=0){
                numRetirado = removeDalista(lista, -1, referencia--);
                Console.Write("\t" + numRetirado);
                listaAux[pos++] = numRetirado;
            }
            return listaAux; 
        }
    }
}

