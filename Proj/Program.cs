using Proj.DB;
using Proj.Model;
namespace Proj
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var pdb = new ProdutoDB();
            var cdb = new ClienteDB();
            
            int op, escolha;
            bool sair = false;
            while (!sair)
            {
                Interface.MenuPrincipal();
                op = int.Parse(Console.ReadLine());
                Operacoes.OperacaoPrincipal(op, sair, pdb, cdb);

            }

        }
    }
}
