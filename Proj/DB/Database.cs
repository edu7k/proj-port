using System.Security.Cryptography.X509Certificates;
using Proj.Model;
using Proj.DB;

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
}

