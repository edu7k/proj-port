using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    public class Operacoes
    {
        public static void OperacaoPrincipal(int opcao, bool sair)
        {
                switch (opcao)
                {
                    case 1:
                        Interface.MenuProdutos();
                        opcao = int.Parse(Console.ReadLine());
                        OperacaoProdutos(opcao, sair);
                        break;
                    case 2:
                        Interface.MenuClientes();
                        opcao = int.Parse(Console.ReadLine());
                        OperacaoCliente(opcao, sair);
                        break;
                    case 3:
                        sair = true;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

        }
        public static void OperacaoProdutos(int escolha, bool sair)
        {
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Adicionando produto...");
                    break;
                case 2:
                    Console.WriteLine("Relizando venda...");
                    break;
                case 3:
                    Console.WriteLine("Removendo produto...");
                    break;
                case 4:
                    Console.WriteLine("Removendo quantidade...");
                    break;
                case 5:
                    Console.WriteLine("Adicionando quantidade...");
                    break;
                case 6:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        public static void OperacaoCliente(int escolha, bool sair)
        {
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Adicionando cliente...");
                    break;
                case 2:
                    Console.WriteLine("Removendo cliente...");
                    break;
                case 3:
                    Console.WriteLine("Alterando dados...");
                    break;
                case 4:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;

            }
        }

    }
}



