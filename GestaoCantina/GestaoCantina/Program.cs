using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using GestaoCantina;

namespace ProjetoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Produto prod = new Produto();
            Funcionario func = new Funcionario();
            Faturamento fat = new Faturamento();

            x = 1;

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=GestaoCantina;Integrated Security=SSPI");
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
                    func.Turno = Console.ReadLine();
                    Console.Write("Idade:");
                    func.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Salario:");
                    func.Salario = double.Parse(Console.ReadLine());

                    conn.Open();

                    cmd.Parameters.AddWithValue("Nome", func.Nome);
                    cmd.Parameters.AddWithValue("Sexo", func.Sexo);
                    cmd.Parameters.AddWithValue("Turno", func.Turno);
                    cmd.Parameters.AddWithValue("Idade", func.Idade);
                    cmd.Parameters.AddWithValue("Salario", func.Salario);

                    cmd.CommandText = string.Format (@"INSERT 
                                    INTO Funcionario(Nome, Sexo, Turno, Idade, Salario)
                                    VALUES (@Nome, @Sexo, @Turno, @Idade, @Salario);");
                    
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("Nome");
                    cmd.Parameters.RemoveAt("Sexo");
                    cmd.Parameters.RemoveAt("Turno");
                    cmd.Parameters.RemoveAt("Idade");
                    cmd.Parameters.RemoveAt("Salario");

                    conn.Close();
            
                }
                if (x == 2)
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("Nome", func.Nome);
                    cmd.Parameters.AddWithValue("Sexo", func.Sexo);
                    cmd.Parameters.AddWithValue("Turno", func.Turno);
                    cmd.Parameters.AddWithValue("Idade", func.Idade);
                    cmd.Parameters.AddWithValue("Salario", func.Salario);

                    cmd.CommandText = string.Format(@"DELETE * FROM Funcionario
                                                WHERE             

                    ");

                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
                
            }
        }
    }
}