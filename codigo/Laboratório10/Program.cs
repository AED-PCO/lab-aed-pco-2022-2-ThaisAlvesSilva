using System;
using System.Xml.Linq;
using classe;

namespace Exc1
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int op = menuPrincipal();
        
            switch (op)
            {
                case 1:
                    fila();
                    break;
                case 2:
                    pilha();
                    break;
                case 3:
                    lista();
                    break;
                default:
                    break;
            }
        }

        static void fila()
        {
            Console.Clear();
            Fila fila = new Fila();
            int op = menu("FILA"), num;

            while (op != 4)
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Qual valor deseja inserir na fila?");
                        num = int.Parse(Console.ReadLine());
                        fila.inserir(num);
                        break;
                    case 2:
                        fila.retirar();
                        sair();
                        break;
                    case 3:
                        fila.imprimir();
                        sair();
                        break;
                }
                Console.Clear();
                op = menu("FILA");
            }
        }

        static void pilha()
        {
            Console.Clear();
            Pilha pilha = new Pilha();
            int op = menu("PILHA"), num;

            while (op != 4)
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Qual valor deseja inserir na pilha?");
                        num = int.Parse(Console.ReadLine());
                        pilha.inserir(num);
                        break;
                    case 2:
                        pilha.retirar();
                        sair();
                        break;
                    case 3:
                        pilha.imprimir();
                        sair();
                        break;
                }
                Console.Clear();
                op = menu("PILHA");
            }
        }

        static void lista()
        {
            Console.Clear();
            Lista lista = new Lista();
            int op = menu("LISTA"), num, pos;
            char resp = 'N';

            while (op != 4)
            {
                switch (op)
                {
                    case 1:

                        Console.WriteLine("Deseja escolher uma posição para adicionar (s)im ou (n)ão?");
                        resp = char.Parse(Console.ReadLine());
                        if (resp == 's' || resp == 'S')
                        {
                            Console.WriteLine("Em qual posição deseja inserir o valor?");
                            pos = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            pos = -1;
                        }
                        Console.WriteLine("Qual valor deseja inserir na lista?");
                        num = int.Parse(Console.ReadLine());
                        lista.inserir(num, pos);
                        break;
                    case 2:
                        Console.WriteLine("Deseja escolher um valor específico para retirar da lista (s)im ou (n)ão?");
                        resp = char.Parse(Console.ReadLine());
                        if (resp == 's' || resp == 'S')
                        {
                            Console.WriteLine("Qual valor deseja retirar?");
                            num = int.Parse(Console.ReadLine());
                            lista.retirar(num, true);
                        }
                        else
                        {
                            lista.retirar(0, false);
                        }
                        sair();
                        break;
                    case 3:
                        lista.imprimir();
                        sair();
                        break;
                }
                Console.Clear();
                op = menu("LISTA");
            }
        }


        static int menu(string estrutura)
        {
                int op;
                Console.WriteLine("==============================");
                Console.WriteLine("|(1)INSERIR NA " + estrutura +"           |");
                Console.WriteLine("|(2)RETIRAR DA " + estrutura + "           |");
                Console.WriteLine("|(3)MOSTRAR A " + estrutura + "            |");
                Console.WriteLine("|(4)SAIR    		      |");
                Console.WriteLine("==============================");
                op = int.Parse(Console.ReadLine());
                return op;
            
        }

        static int menuPrincipal()
        {
            int op;
            Console.WriteLine("========================");
            Console.WriteLine("|(1)FILA              |");
            Console.WriteLine("|(2)PILHA	      |");
            Console.WriteLine("|(3)LISTA	      |");
            Console.WriteLine("========================");
            op = int.Parse(Console.ReadLine());
            return op;
        }

        static void sair()
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
        }

    }

    
}
