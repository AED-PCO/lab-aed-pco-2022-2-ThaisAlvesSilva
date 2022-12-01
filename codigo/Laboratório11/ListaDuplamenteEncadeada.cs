using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaDuplamenteEncad
{
    public class ListaDuplamenteEncadeada
    {
        public Elemento primeiro;
        public Elemento ultimo;

        public ListaDuplamenteEncadeada()
        {
            primeiro = ultimo = new Elemento();
            primeiro.aluno = null;
            primeiro.proximo = null;
            primeiro.anterior = null;
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
                novo.anterior = primeiro;
                primeiro.proximo = novo;
                ultimo = novo;
            }
            else
            {
                if (pos == -1)      //vai inserir no final da lista
                {
                    novo.anterior = ultimo;
                    ultimo.proximo = novo;
                    ultimo = novo;
                }
                else                //vai inserir em uma posição específica
                {

                    Elemento aux = primeiro;
                    while (cont < pos && aux.proximo != null)
                    {
                        cont++;
                        aux = aux.proximo;

                    }
                    if(aux.proximo == null)
                    {
                        novo.anterior = ultimo;
                        ultimo.proximo = novo;
                        ultimo = novo;
                    }
                    else
                    {

                        novo.anterior = aux;
                        aux.proximo.anterior = novo;
                        novo.proximo = aux.proximo;
                        aux.proximo = novo;
                    }
                    
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
                Elemento aux = primeiro.proximo;
                Elemento auxRet;
                bool achou = false;
                if (isNum && ultimo.aluno.nota != num)               //vai retirar um valor específico 
                {

                    while (aux != null)
                    {
                        if (aux.aluno.nota == num)
                        {
                            achou = true;
                            break;
                        }

                        aux = aux.proximo;

                    }

                    if (achou)
                    {
                        
                        aux.anterior.proximo = aux.proximo;
                        aux.proximo.anterior = aux.anterior;
                        aux.proximo = aux.anterior = null;
  
                        
                        Console.WriteLine($"\nElemento {aux.aluno.nota} retirado da lista com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"\nElemento não encontrado na lista!");
                    }

                }
                else            //vai retirar o último elemento
                {

                    while (aux.proximo != null)
                    {
                        aux = aux.proximo;
                    }

                    auxRet = aux;
                    ultimo = aux.anterior;
                    aux.anterior.proximo = null;
                    
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

        public void imprimeInverso()
        {
            Elemento dado = ultimo;

            Console.WriteLine("\nElementos da lista INVERSA:");
            while (dado != primeiro)
            {
                Console.Write("\t" + dado.aluno.nota);
                dado = dado.anterior;
            }
        }
    }
}
