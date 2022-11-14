using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe
{
    public class Fila
    {
        public Elemento primeiro;
        public Elemento ultimo;

        public Fila()
        {
            primeiro = new Elemento();
            ultimo = new Elemento();
            primeiro.aluno = null;
            primeiro.proximo = null;
            ultimo = this.primeiro;
        }

        public bool isVazia()
        {
            return primeiro.proximo == null ? true :  false;
        }

        public void inserir(Elemento novo) {
            if (isVazia()){
                primeiro.proximo = novo;
                ultimo = novo;
            }
            else
            {
                ultimo.proximo = novo;
                ultimo = novo;
            }
        }
        public void retirar() {
            if (isVazia())
            {
                Console.WriteLine("Não há elementos na fila para serem retirados!");
            }
            else
            {
                Console.WriteLine($"\n\nElemento {primeiro.proximo.aluno.nota} retirado da fila com sucesso!");
                primeiro.proximo = primeiro.proximo.proximo;
                
            }
        }

          public void imprimir() {
            Elemento dado = this.primeiro.proximo;

            Console.WriteLine("\nElementos da fila:");
            while(dado != null)
            {
                Console.Write("\t" + dado.aluno.nota);
                dado = dado.proximo;
            }
        }
    }
}
