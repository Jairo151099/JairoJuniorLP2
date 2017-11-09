using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBASE
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conexao = new SqlConnection("Server=localhost;Database=escola;Uid=root;Pwd=");
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conexao;
            cmd.CommandText = "INSERT INTO PROFESSOR(Nome, Siape, Salario) VALUES ('Pedro', '123789', 20000);";

            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();

            Console.WriteLine("OK");
                    
        }
    }
}
