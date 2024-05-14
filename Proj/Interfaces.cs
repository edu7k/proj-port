using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using Proj.DB;

namespace Proj
{
    public class Interface
    {
        public static void MenuPrincipal()
        {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Produtos");
                Console.WriteLine("2. Clientes");
                Console.WriteLine("3. Sair");
        }

        public static void MenuProdutos()
        {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. CADASTRAR NOVO PRODUTO");
                Console.WriteLine("2. REALIZAR VENDA");
                Console.WriteLine("3. REMOVER PRODUTO");
                Console.WriteLine("4. REMOVER QUANTIDADE");
                Console.WriteLine("5. ADICIONAR QUANTIDADE");
                Console.WriteLine("6. VOLTAR");
        }

        public static void MenuClientes()
        {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. CADASTRAR NOVO CLIENTE");
                Console.WriteLine("2. REMOVER CLIENTE");
                Console.WriteLine("3. ALTERAR DADOS");
                Console.WriteLine("4. VOLTAR");    
        }

        public static void MostraProdutos(ProdutoDB pdb)
        {
            var table = pdb.GetProduto();

            ConsoleTable.From(table).Write();

        }

        public static void MostraClientes(ClienteDB cdb)
        {
            var table = cdb.GetClientes();

            ConsoleTable.From(table).Write();

        }

        public static void MostraVendas(VendaDB vdb)
        {
            var table = vdb.GetVendas();

            ConsoleTable.From(table).Write();

        }

    }

}

