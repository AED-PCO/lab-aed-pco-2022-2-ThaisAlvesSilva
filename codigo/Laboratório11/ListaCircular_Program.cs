using System;
using System.Xml.Linq;

namespace listaCircular
{
    class Program
    {
        static void Main(string[] args)
        {
            lista();
        }
        static void lista()
        {
            Console.Clear();
            listaCircular lista = new listaCircular();
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
                        
                        lista.retirar();
                        
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
            Console.WriteLine("|(1)INSERIR NA " + estrutura + "           |");
            Console.WriteLine("|(2)RETIRAR DA " + estrutura + "           |");
            Console.WriteLine("|(3)MOSTRAR A " + estrutura + "            |");
            Console.WriteLine("|(4)SAIR    		      |");
            Console.WriteLine("==============================");
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
