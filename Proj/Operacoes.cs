using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj.Model;

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
        public static void OperacaoProdutos(int escolha, bool sair, ProdutoDB pdb)
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


        public static void AddProduto(ProdutoDB pdb)
        {
            var Cadastra = new Produto();
            Cadastra.Id = pdb.GetProduto().Count() + 1;
            
            Console.WriteLine("Nome do Produto: ");
            Cadastra.Nome = Console.ReadLine();
            Console.WriteLine("Quantidade de Produtos: ");
            Cadastra.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Preco do Produto: ");
            Cadastra.Preco = double.Parse(Console.ReadLine());

            pdb.Estoque.Add(Cadastra);
        }

        public static void RemoveProduto(ProdutoDB pdb) 
        {
        
        }

        public static void AddCliente(ClienteDB cdb)
        {
            var Cadastra = new Cliente();
            Cadastra.Id = cdb.GetClientes().Count() + 1;

            Console.WriteLine("Nome do Cliente: ");
            Cadastra.Nome = Console.ReadLine();
            Console.WriteLine("Digite CPF: ");
            Cadastra.Cpf = Console.ReadLine();
            

            cdb.Clientes.Add(Cadastra);
        }


    }
}



