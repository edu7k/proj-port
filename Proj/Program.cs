namespace Proj
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op, escolha;
            bool sair = false;
            while (!sair)
            {
                Interface.MenuPrincipal();
                op = int.Parse(Console.ReadLine());
                Operacoes.OperacaoPrincipal(op, sair);

            }

        }
    }
}
