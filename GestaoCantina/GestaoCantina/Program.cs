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
            int x, y, z, w, del4, dele3;
            double del5, dele2, delet1, delet2, Despesa = 0;
            string del1, del2, del3, dele1;
            Produto prod = new Produto();
            Funcionario func = new Funcionario();
            Faturamento fat = new Faturamento();

            x = 1;

            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=GestaoCantina;Integrated Security=SSPI");
            cmd.Connection = conn;

            Console.WriteLine(" 1 - Adicionar funcionário\n 2 - Remover funcionário\n 3 - Consultar funcionário\n 4 - Alterar funcionário\n 5 - Adicionar produto\n 6 - Remover produto\n 7 - Consultar produto\n 8 - Alterar produto\n 9 - Adicionar faturamento\n 10 - Remover faturamento\n 11 - Consultar faturamento\n 12 - Alterar faturamento\n :");
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

                    cmd.CommandText = string.Format(@"INSERT 
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
                        cmd.CommandText = @"DELETE FROM Funcionario
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
                        cmd.CommandText = @"DELETE FROM Funcionario
                                            WHERE Sexo = @sexo";

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
                        cmd.CommandText = @"DELETE FROM Funcionario
                                            WHERE Turno = @turno";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Turno");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (y == 4)
                    {
                        Console.WriteLine("Informa a idade a ser deletado");
                        del4 = int.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Idade", del4);
                        cmd.CommandText = @"DELETE FROM Funcionario
                                            WHERE Idade = @idade";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Idade");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (y == 5)
                    {
                        Console.WriteLine("Informe o salario a ser deletado");
                        del5 = double.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Salario", del5);
                        cmd.CommandText = @"DELETE FROM Funcionario
                                            WHERE Salario = @salario";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Salario");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                }

                else if (x == 3)
                {
                    Console.WriteLine("Informe o ID do Funcionario");
                    int Id = int.Parse(Console.ReadLine());

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandText = @"SELECT Nome, Sexo , Salario, Turno, Idade
                                FROM Funcionario WHERE Id = @Id;";



                    SqlDataReader ler = cmd.ExecuteReader();
                    if (ler.HasRows)
                    {

                        while (ler.Read())
                        {
                            string Nome = ler.GetString(0);
                            string Sexo = ler.GetString(1);
                            double Salario = ler.GetDouble(2);
                            string Turno = ler.GetString(3);
                            int Idade = ler.GetInt32(4);

                            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", Nome, Sexo, Salario, Turno, Idade);
                        }

                    }
                    cmd.Connection.Close();
                }
                else if (x == 4)
                {
                    Console.WriteLine("Informe o ID do Funcionario");
                    int Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe novo salário");
                    cmd.Connection.Open();
                    func.Salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe novo turno");
                    func.Turno = Console.ReadLine();

                    cmd.Parameters.AddWithValue("Salario", func.Salario);
                    cmd.Parameters.AddWithValue("Turno", func.Turno);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.CommandText = @"UPDATE Funcionario
                                                        SET Salario = @salario, Turno = @Turno
                                                        WHERE Id = @id;";


                    cmd.ExecuteNonQuery();



                    cmd.Connection.Close();

                    Console.WriteLine("Alteração concluída");
                }
                else if (x == 5)
                {
                    Console.WriteLine("Determine:");

                    Console.Write("Nome:");
                    prod.Nome = Console.ReadLine();
                    Console.Write("Valor:");
                    prod.Valor = double.Parse(Console.ReadLine());
                    Console.Write("Quantidade:");
                    prod.Quantidade = int.Parse(Console.ReadLine());


                    conn.Open();

                    cmd.Parameters.AddWithValue("Nome", prod.Nome);
                    cmd.Parameters.AddWithValue("Valor", prod.Valor);
                    cmd.Parameters.AddWithValue("Quantidade", prod.Quantidade);

                    cmd.CommandText = string.Format(@"INSERT 
                                    INTO Produto(Nome, Valor, Quantidade)
                                    VALUES (@Nome, @Valor, @Quantidade);");

                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("Nome");
                    cmd.Parameters.RemoveAt("Valor");
                    cmd.Parameters.RemoveAt("Quantidade");

                    conn.Close();
                }
                else if (x == 6)
                {
                    Console.WriteLine("\n1- Deletar Nome \n2- Deletar valor \n3- Deletar Quantidade");
                    z = int.Parse(Console.ReadLine());

                    if (z == 1)
                    {

                        Console.WriteLine("Informe o nome a ser deletado");
                        dele1 = Console.ReadLine();
                        conn.Open();
                        cmd.Parameters.AddWithValue("Nome", dele1);
                        cmd.CommandText = @"DELETE FROM Produto
                                            WHERE Nome = @nome";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Nome");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (z == 2)
                    {

                        Console.WriteLine("Informe o valor a ser deletado");
                        dele2 = double.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Valor", dele2);
                        cmd.CommandText = @"DELETE FROM Produto
                                            WHERE Valor = @valor";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Valor");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (z == 3)
                    {

                        Console.WriteLine("Informe a quantidade a ser deletada");
                        dele3 = int.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Quantidade", dele3);
                        cmd.CommandText = @"DELETE FROM Produto
                                            WHERE Quantidade = @quantidade";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Quantidade");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    
                }
                else if (x == 7)
                {
                    Console.WriteLine("Informe o ID do produto");
                    int Id = int.Parse(Console.ReadLine());

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandText = @"SELECT Nome, Valor, Quantidade
                                FROM Produto WHERE Id = @Id;";



                    SqlDataReader ler = cmd.ExecuteReader();
                    if (ler.HasRows)
                    {

                        while (ler.Read())
                        {
                            string Nome = ler.GetString(0);
                            double Valor = ler.GetDouble(1);
                            int Quantidade = ler.GetInt32(2);

                            Console.WriteLine("{0} \n{1} \n{2}", Nome, Valor, Quantidade);
                        }

                    }
                    cmd.Connection.Close();
                }
                else if (x == 8)
                {
                    Console.WriteLine("Informe o ID do Produto");
                    int Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o nome do novo Produto");
                    cmd.Connection.Open();
                    prod.Nome = Console.ReadLine();
                    
                    Console.WriteLine("Informe novo valor");
                    prod.Valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe nova quantidade");
                    prod.Quantidade = int.Parse(Console.ReadLine());

                    cmd.Parameters.AddWithValue("Nome", prod.Nome);
                    cmd.Parameters.AddWithValue("Valor", prod.Valor);
                    cmd.Parameters.AddWithValue("Quantidade", prod.Quantidade);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.CommandText = @"UPDATE Produto
                                                        SET Nome = @nome, Valor = @valor, Quantidade = @quantidade
                                                        WHERE Id = @id;";


                    cmd.ExecuteNonQuery();



                    cmd.Connection.Close();

                    Console.WriteLine("Alteração concluída");
                }
                else if (x == 9)
                {
                    Console.WriteLine("Determine:");

                    Console.Write("Lucro:");
                    fat.Lucro = double.Parse(Console.ReadLine());
                    Console.Write("Preco:");
                    fat.Preco = double.Parse(Console.ReadLine());

                    conn.Open();

                    cmd.Parameters.AddWithValue("Lucro", fat.Lucro);
                    cmd.Parameters.AddWithValue("Preco", fat.Preco);


                    cmd.CommandText = string.Format(@"INSERT 
                                    INTO Faturamento(Lucro, Preco)
                                    VALUES (@Lucro, @Preco);");

                    cmd.ExecuteNonQuery();

                    cmd.Parameters.RemoveAt("Lucro");
                    cmd.Parameters.RemoveAt("Preco");

                    conn.Close();
                }
                
                else if (x == 10)
                {
                    Console.WriteLine("\n1- Deletar Lucro \n2- Deletar Preco");
                    w = int.Parse(Console.ReadLine());

                    if (w == 1)
                    {

                        Console.WriteLine("Informe o Lucro a ser deletado");
                        delet1 = double.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Lucro", delet1);
                        cmd.CommandText = @"DELETE FROM Faturamento
                                            WHERE Lucro = @Lucro";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Lucro");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
                    else if (w == 2)
                    {

                        Console.WriteLine("Informe a Preco a ser deletada");
                        delet2 = double.Parse(Console.ReadLine());
                        conn.Open();
                        cmd.Parameters.AddWithValue("Preco", delet2);
                        cmd.CommandText = @"DELETE FROM Faturamento
                                            WHERE Faturamento = @Faturamento";

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.RemoveAt("Faturamento");
                        conn.Close();

                        Console.WriteLine("Delete concluído");

                    }
               
                    cmd.Connection.Close();

                }
                else if (x == 11)
                {
                    Console.WriteLine("Informe o ID do Faturamento");
                    int Id = int.Parse(Console.ReadLine());

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.CommandText = @"SELECT Lucro, Preco
                                FROM Faturamento WHERE Id = @Id;";

                    SqlDataReader ler = cmd.ExecuteReader();
                    if (ler.HasRows)
                    {

                        while (ler.Read())
                        {

                            double Lucro = ler.GetDouble(0);
                            double preco = ler.GetDouble(1);


                            Console.WriteLine("{0} \n{1}", Lucro, preco );
                        }
                        Despesa = fat.Lucro - fat.Preco;
                        Console.WriteLine("A despesa é {0}", Despesa);
                    }
                    cmd.Connection.Close();

                }
                else if (x == 12)
                {
                    Console.WriteLine("Informe o ID do faturamento");
                    int Id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o novo Lucro");
                    cmd.Connection.Open();
                    fat.Lucro = double.Parse(Console.ReadLine());

                    Console.WriteLine("Informe novo preco");
                    fat.Preco = double.Parse(Console.ReadLine());

                    cmd.Parameters.AddWithValue("Lucro", fat.Lucro);
                    cmd.Parameters.AddWithValue("Preco", fat.Preco);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.CommandText = @"UPDATE Faturamento
                                                        SET Lucro = @lucro, Preco = @preco
                                                        WHERE Id = @id;";


                    cmd.ExecuteNonQuery();



                    cmd.Connection.Close();
                    Console.WriteLine("Alteração concluída");
                }
             }
         }
     }

}
