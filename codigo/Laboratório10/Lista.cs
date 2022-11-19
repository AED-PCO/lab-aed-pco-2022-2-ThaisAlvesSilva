using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Lista
    {
        public Elemento primeiro;
        public Elemento ultimo;

        public Lista()
        {
            primeiro = new Elemento();
            ultimo = new Elemento();
            primeiro.aluno = null;
            primeiro.proximo = null;
            ultimo = this.primeiro;
        }

        public bool isVazia()
        {
            return primeiro.proximo == null ? true : false;
        }

        public void inserir(int nota, int pos = -1)
        {
            int cont = 1;
            Elemento novo = new Elemento();
            novo.aluno.nota = nota;
            if (isVazia())
            {
                primeiro.proximo = novo;
                ultimo = novo;
            }
            else
            {
                if (pos == -1)      //vai inserir no final da lista
                {
                    
                    ultimo.proximo = novo;
                    ultimo = novo;
                }
                else                //vai inserir em uma posição específica
                {
                    
                    Elemento aux = primeiro;
                    Elemento auxRet;
                    while (cont < pos && aux.proximo != null)
                    {
                        cont++;
                        aux = aux.proximo;

                    }

                    novo.proximo = aux.proximo;
                    aux.proximo = novo;
                }
                
            }
        }
        public void retirar(int num, bool isNum)
        {
            if (isVazia())
            {
                Console.WriteLine("Não há elementos na lista para serem retirados!");
            }
            else
            {
                Elemento aux = primeiro;
                Elemento auxRet;
                bool achou = false;
                if (isNum)               //vai retirar um valor específico 
                {
                   
                    while (aux.proximo != null)
                    {
                        if (aux.proximo.aluno.nota == num)
                        {
                            achou = true;
                            break;
                        }
                           
                        aux = aux.proximo;
                        
                    }

                    if (achou)
                    {
                        auxRet = aux.proximo;
                        aux.proximo = auxRet.proximo;
                        Console.WriteLine($"\nElemento {auxRet.aluno.nota} retirado da lista com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"\nElemento não encontrado na lista!");
                    }
                    
                }
                else            //vai retirar o último elemento
                {
                    
                    while(aux.proximo.proximo != null)
                    {
                        aux = aux.proximo;
                    }

                    auxRet = aux.proximo;
                    aux.proximo = auxRet.proximo;
                    ultimo = aux;

                    Console.WriteLine($"\nElemento {auxRet.aluno.nota} retirado da lista com sucesso!");
                }
                
              
            }
        }
        public void imprimir()
        {
            Elemento dado = primeiro.proximo;

            Console.WriteLine("\nElementos da lista:");
            while (dado != null)
            {
                Console.Write("\t" + dado.aluno.nota);
                dado = dado.proximo;
            }
        }
    }
}
