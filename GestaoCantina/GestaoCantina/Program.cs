using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Produto prod = new Produto();
            Funcionario func = new Funcionario();

            x = 1;

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=LPBD;Integrated Security=SSPI");

            cmd.Connection = conn;

            while (x != 0)
            {
                Console.WriteLine(" 1 - Adicionar funcionário\n 2 - Remover funcionário\n 3 - Consultar funcionário\n 4 - Alterar funcionário\n 5 - Adicionar produto\n 6 - Remover produto\n 7 - Consultar produto\n 8 - Alterar produto\n 9 - Adicionar faturamento\n 10 - Remover faturamento\n 11 - Alterar faturamento\n 12 - Consultar faturamento\n :");

                x = int.Parse(Console.ReadLine());

                if (x == 1)
                {

                    Console.WriteLine("Determine:");

                    Console.Write("Nome:");
                    func.Nome = Console.ReadLine();
                    Console.Write("Sexo:");
                    func.Sexo = Console.ReadLine();
                    Console.Write("Turno:");
                    func.Turno = double.Parse(Console.ReadLine());
                    Console.Write("Idade:");
                    func.idade = int.Parse(Console.ReadLine());
                    Console.Write("Salario:");
                    func.salario = Console.ReadLine();
                }
            }
        }
    }
}