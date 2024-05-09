using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    public class Interface
    {
        public static void MenuPrincipal()
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Produtos");
                Console.WriteLine("2. Clientes");
                Console.WriteLine("3. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        MenuProdutos();
                        break;
                    case 2:
                        MenuClientes();
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
        }

        static void MenuProdutos()
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. CADASTRAR NOVO PRODUTO");
                Console.WriteLine("2. REALIZAR VENDA");
                Console.WriteLine("3. REMOVER PRODUTO");
                Console.WriteLine("4. REMOVER QUANTIDADE");
                Console.WriteLine("5. ADICIONAR QUANTIDADE");
                Console.WriteLine("6. VOLTAR");

                int escolha = int.Parse(Console.ReadLine());

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
        }

        static void MenuClientes()
        {
            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. CADASTRAR NOVO CLIENTE");
                Console.WriteLine("2. REMOVER CLIENTE");
                Console.WriteLine("3. ALTERAR DADOS");
                Console.WriteLine("4. VOLTAR");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Adicionando cliente...");
                        break;
                    case 2:
                        Console.WriteLine("Removendo cliente...");
                        break;
                    case 3:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }

}

