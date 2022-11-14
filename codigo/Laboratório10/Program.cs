using System;
using System.Xml.Linq;
using classe;

namespace lista_filha_pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            Lista lista = new Lista();
            Pilha pilha = new Pilha();
            int num;

            Console.WriteLine("-----------------------FILA----------------------------------------------");

            Elemento elementoFila = new Elemento();
            Elemento elementoFila2 = new Elemento();
            Elemento elementoFila3 = new Elemento();
            Elemento elementoFila4 = new Elemento();

            elementoFila.aluno.nota = 8;
            elementoFila2.aluno.nota = 23;
            elementoFila3.aluno.nota = 42;
            elementoFila4.aluno.nota = 15;

            fila.inserir(elementoFila);
            fila.inserir(elementoFila2);
            fila.inserir(elementoFila3);
            fila.inserir(elementoFila4);

            fila.imprimir();

            fila.retirar();

            fila.imprimir();


            Console.WriteLine("\n\n\n-----------------------PILHA----------------------------------------------");

            Elemento elementoPilha = new Elemento();
            Elemento elementoPilha2 = new Elemento();
            Elemento elementoPilha3 = new Elemento();
            Elemento elementoPilha4 = new Elemento();


            elementoPilha.aluno.nota = 88;
            elementoPilha2.aluno.nota = 233;
            elementoPilha3.aluno.nota = 11;
            elementoPilha4.aluno.nota = 25;

            pilha.inserir(elementoPilha);
            pilha.inserir(elementoPilha2);
            pilha.inserir(elementoPilha3);
            pilha.inserir(elementoPilha4);

            pilha.imprimir();

            pilha.retirar();

            pilha.imprimir();

            Console.WriteLine("\n\n\n-----------------------LISTA----------------------------------------------");

            Elemento elementoLista = new Elemento();
            Elemento elementoLista2 = new Elemento();
            Elemento elementoLista3 = new Elemento();
            Elemento elementoLista4 = new Elemento();

            elementoLista.aluno.nota = 4;
            elementoLista2.aluno.nota = 78;
            elementoLista3.aluno.nota = 40;

            lista.inserir(elementoLista);
            lista.inserir(elementoLista2);
            lista.inserir(elementoLista3);

            lista.imprimir();

            Console.WriteLine("\n\nEm qual posição deseja inserir o novo elemento na lista?");
            int pos = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nQual valor deseja inserir na lista?");
            num = int.Parse(Console.ReadLine());

            elementoLista4.aluno.nota = num;

            lista.inserir(elementoLista4, pos);

            lista.imprimir();

            Console.WriteLine("\n\nQual elemento deseja retirar da lista?");
            num = int.Parse(Console.ReadLine());

            lista.retirar(num, true);            // RETIRANDO UM ELEMENTO ESPECÍFICO DA LISTA

            Console.WriteLine("\nRetirando o último elemento da lista:");
            lista.retirar(-1, false);           // RETIRANDO O ÚLTIMO ELEMENTO DA LISTA

            lista.imprimir();

        }

    }

    
}
