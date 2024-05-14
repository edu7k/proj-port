using System.Security.Cryptography.X509Certificates;
using Proj.Model;
using Proj.DB;
using proj.Model;

namespace Proj.DB
{
    public class ProdutoDB
    {
        public List<Produto> Estoque { get; set; }

        public ProdutoDB()
        {
            Estoque = new List<Produto>();
        }
        public List<Produto> GetProduto() => Estoque;

    }

    public class ClienteDB
    {
        public List<Cliente> Clientes { get; set; }

        public ClienteDB()
        {
            Clientes = new List<Cliente>();
        }
        public List<Cliente> GetClientes() => Clientes;
    }

    public class VendaDB 
    {
        public List<VendaItem> ItensVendidos { get; set; }
        
        public VendaDB()
        {
            ItensVendidos = new List<VendaItem>();
        }

        public List<VendaItem> GetVendas() => ItensVendidos;
    }
}

