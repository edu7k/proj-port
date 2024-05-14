using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proj.Model;
using Proj.DB;
using Proj.Model;

namespace Proj
{
    public class Operacoes
    {
        public static void OperacaoPrincipal(int opcao, bool sair, ProdutoDB pdb, ClienteDB cdb, VendaDB vdb)
        {
            switch (opcao)
            {
                case 1:
                    Interface.MenuProdutos();
                    opcao = int.Parse(Console.ReadLine());
                    OperacaoProdutos(opcao, sair, pdb, cdb, vdb);
                    break;
                case 2:
                    Interface.MenuClientes();
                    opcao = int.Parse(Console.ReadLine());
                    OperacaoCliente(opcao, sair, cdb);
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
        public static void OperacaoProdutos(int escolha, bool sair, ProdutoDB pdb, ClienteDB cdb, VendaDB vdb)
        {
            switch (escolha)
            {
                case 1:

                    Console.WriteLine("Adicionando produto...");
                    AddProduto(pdb);
                    Interface.MostraProdutos(pdb);
                    break;
                case 2:
                    RealizarVenda(cdb, pdb, vdb);
                    Interface.MostraVendas(vdb);
                    Console.WriteLine("Relizando venda...");
                    break;
                case 3:
                    RemoveProduto(pdb);
                    Console.WriteLine("Removendo produto...");
                    break;
                case 4:
                    RemoveQuantidade(pdb);
                    Console.WriteLine("Removendo quantidade...");
                    break;
                case 5:
                    AddQuantidade(pdb);
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
        public static void OperacaoCliente(int escolha, bool sair, ClienteDB cdb)
        {
            switch (escolha)
            {
                case 1:
                    AddCliente(cdb);
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
            int id, removido;
            Interface.MostraProdutos(pdb);
            Console.WriteLine("Selecione ID do produto a remover: ");
            id = int.Parse(Console.ReadLine());
            removido = pdb.Estoque.RemoveAll(Produto => Produto.Id == id);

            if (removido > 0)
            {
                Console.WriteLine("Removido!");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Não está na lista");
                return;
            }


        }

        public static void AddQuantidade(ProdutoDB pdb)
        {
            Interface.MostraProdutos(pdb);
            Console.WriteLine("Selecione ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quantidade a ser adicionada: ");
            int qnt = int.Parse(Console.ReadLine());

            foreach (var Produto in pdb.Estoque)
            {
                if (Produto.Id == id)
                {
                    Produto.Quantidade += qnt;
                    Console.WriteLine("Quantidade Adicionada!");
                }
                else
                {
                    Console.WriteLine("Produto não ta na lista");
                    return;
                }
            }

        }

        public static void RemoveQuantidade(ProdutoDB pdb)
        {
            Interface.MostraProdutos(pdb);
            Console.WriteLine("Selecione ID do produto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Quantidade a ser removido: ");
            int qnt = int.Parse(Console.ReadLine());

            foreach (var Produto in pdb.Estoque)
            {
                if (Produto.Id == id)
                {
                    Produto.Quantidade -= qnt;
                    Console.WriteLine("Quantidade Removida!");
                }
                else
                {
                    Console.WriteLine("Produto não ta na lista");
                    return;
                }
            }

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

        

        public static void RealizarVenda(ClienteDB cdb, ProdutoDB pdb, VendaDB vdb)
        {
            int op = 1;
            var produtVendido = new VendaItem();

            do
            {
                Console.WriteLine("Selecione Id do produto: ");
                int idProd = int.Parse(Console.ReadLine());
                Console.WriteLine("Selecione a quantidade de Produtos: ");
                int quant = int.Parse(Console.ReadLine());


                foreach (var produto in pdb.Estoque)
                {
                    if (produto.Id == idProd)
                    {
                        produtVendido.IdProduto = produto.Id;
                        produtVendido.QuantidadeVenda = quant;
                        produtVendido.NomeProduto = produto.Nome;
                        produtVendido.PrecoVenda = quant * produto.Preco;
                        produtVendido.SaleTime = DateTime.Now;

                    }

                }
                vdb.ItensVendidos.Add(produtVendido);

                Console.WriteLine("1 - Sim  2 - Não");
                Console.WriteLine("Deseja Continuar? ");
                op = int.Parse(Console.ReadLine());

            } while (op != 2);

            Console.WriteLine("Venda Realizada!");
        }
    }
}



