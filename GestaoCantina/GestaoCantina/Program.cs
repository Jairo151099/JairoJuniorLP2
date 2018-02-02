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
            int x, y, del4;
            double del5;
            string del1, del2, del3;
            Produto prod = new Produto();
            Funcionario func = new Funcionario();
            Faturamento fat = new Faturamento();

            x = 1;

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=GestaoCantina;Integrated Security=SSPI");
            cmd.Connection = conn;

            Console.WriteLine(" 1 - Adicionar funcionário\n 2 - Remover funcionário\n 3 - Consultar funcionário\n 4 - Alterar funcionário\n 5 - Adicionar produto\n 6 - Remover produto\n 7 - Consultar produto\n 8 - Alterar produto\n 9 - Adicionar faturamento\n 10 - Remover faturamento\n 11 - Alterar faturamento\n 12 - Consultar faturamento\n :");
            while (x != 0)
            {

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
                else if (x == 2)
                {
                    Console.WriteLine("\n1- Deletar Nome \n2- Deletar Sexo \n3- Deletar Turno\n4- Deletar Idade\n5- Deletar Salario");
                    y = int.Parse(Console.ReadLine());

                    if (y == 1)
                    {

                        Console.WriteLine("Informe o nome a ser deletado");
                        del1 = Console.ReadLine();
                        conn.Open();
                        cmd.Parameters.AddWithValue("nome", del1);
                        cmd.CommandText = @"DELETE * FROM Funcionario
                                            WHERE Nome = @nome";
                        
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Nome");
                        conn.Close();

                        Console.WriteLine("Delete concluído");
                        
                    }
                    else if (y == 2)
                    {
                       
                        Console.WriteLine("Informe o sexo a ser deletado");
                        del2 = Console.ReadLine();
                        conn.Open();
                        cmd.Parameters.AddWithValue("Sexo", del2);
                        cmd.CommandText = @"DELETE * FROM Funcionario
                                            WHERE Sexo = @Sexo";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Sexo");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (y == 3)
                    {
                        
                        Console.WriteLine("Informe o Turno a ser deletado");
                        del3 = Console.ReadLine();
                        conn.Open();
                        cmd.Parameters.AddWithValue("Turno", del3);
                        cmd.CommandText = @"DELETE * FROM Funcionario
                                            WHERE Turno = @Turno";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Turno");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (y == 4)
                    {
                        SqlCommand cmmd = new SqlCommand();
                        SqlConnection connn = new SqlConnection("Data Source=localhost;Initial Catalog=GestaoCantina;Integrated Security=SSPI");
                        Console.WriteLine("Informa a idade a ser deletado");
                        del4 = int.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Sexo", del4);
                        cmd.CommandText = @"DELETE * FROM Funcionario
                                            WHERE Sexo = @Sexo";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Sexo");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (y == 5)
                    {
                        SqlCommand cmmd = new SqlCommand();
                        SqlConnection connn = new SqlConnection("Data Source=localhost;Initial Catalog=GestaoCantina;Integrated Security=SSPI");
                        Console.WriteLine("Informe o salario a ser deletado");
                        del5 = double.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Salario", del5);
                        cmd.CommandText = @"DELETE * FROM Funcionario
                                            WHERE Salario = @Salario";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Salario");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }       
                }
                else if (x == 3)
                {
 
                    conn.Open();
                    CommandText = @"SELECT Id, Sexo, Nome, Salário, Idade, Turno
                                FROM Funcionário;";
                    SqlDataReader ler = cmd.ExecuteReader();
                    if (ler.HasRows)
                    {
                        while(ler.Read())
                        {
                            int Id = ler.GetInt32(0);
                            string Sexo = ler.GetString(1);
                            string Nome = ler.GetString(2);
                            string Salário = ler.GetString(3);
                            string Idade = ler.GetString(4);
                            string Turno = ler.GetString(5);
                          
                        }

                    }
                    cmd.Connection.Close();
                }

               
            }
        }

        public static string CommandText { get; set; }
    }
}
               