using System;

namespace ABB
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria Arvore = new ArvoreBinaria();

            int num = 0;
            int op = op = menu();

            while (op != 7){

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Informe um valor para inserir: ");
                        num = int.Parse(Console.ReadLine());
                        Arvore.inserir(num);
                        sair();
                        break;
                    case 2:
                        bool resultado;
                        Console.WriteLine("Informe um valor para pesquisar: ");
                        num = int.Parse(Console.ReadLine());
                        resultado = Arvore.pesquisar(num);
                        Console.WriteLine("O valor é {0}", resultado);
                        sair();
                        break;
                    case 3:
                        Console.WriteLine("Informe um valor para remover: ");
                        num = int.Parse(Console.ReadLine());
                        Arvore.remover(num);
                        sair();
                        break;
                    case 4:
                        Console.WriteLine("Valores da arvore EM ODEM: ");
                        Arvore.EmOrdem();
                        sair();
                        break;
                    case 5:
                        Console.WriteLine("Valores da arvore PRÉ ORDEM: ");
                        Arvore.preOrdem();
                        sair();
                        break;
                    case 6:
                        Console.WriteLine("Valores da arvore PÓS ORDEM: ");
                        Arvore.posOrdem();
                        sair();
                        break;
                    
                    default:
                        break;
                    
                }

                Console.Clear();
                op = menu();
            }
        }

        static int menu(){
            int op;
            Console.WriteLine("==============================");
            Console.WriteLine("|(1) INSERIR");
            Console.WriteLine("|(2) PESQUISAR");
            Console.WriteLine("|(3) REMOVER");
            Console.WriteLine("|(4) IMPRIMIR EM ORDEM");
            Console.WriteLine("|(5) IMPRIMIR PRÉ ORDEM");
            Console.WriteLine("|(6) IMPRIMIR POS ORDEM");
            Console.WriteLine("|(7) SAIR");
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