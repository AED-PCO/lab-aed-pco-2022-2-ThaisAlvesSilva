using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Pilha
    {
        public Elemento primeiro;
        
        public Pilha()
        {
            primeiro = new Elemento();
            primeiro.aluno = null;
            primeiro.proximo = null;
        }

        public bool isVazia()
        {
            return primeiro.proximo == null ? true : false;
        }

        public void inserir(Elemento novo)
        {
            if (isVazia())
            {
                primeiro.proximo = novo;
            }
            else
            {
                novo.proximo = primeiro.proximo;
                primeiro.proximo = novo;
            }
        }
        public void retirar()
        {
            if (isVazia())
            {
                Console.WriteLine("Não há elementos na pilha para serem retirados!");
            }
            else
            {
                Elemento auxRet = primeiro.proximo;
                primeiro.proximo = primeiro.proximo.proximo;
                auxRet.proximo = null;

                Console.WriteLine($"\n\nElemento {auxRet.aluno.nota} retirado da pilha com sucesso!");

            }
        }

        public void imprimir()
        {
            Elemento dado = primeiro.proximo;

            Console.WriteLine("\nElementos da pilha:");
            while (dado != null)
            {
                Console.Write("\t" + dado.aluno.nota);
                dado = dado.proximo;
            }
        }
    }
}
