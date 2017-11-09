using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBASE
{
    class Program
    {
        static void Main(string[] args)
        {


            SqlConnection conexao = new SqlConnection("Data Source=EN2LIA_11;Initial Catalog=Futebol; Integrated Security=SSPI;" );
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conexao;
            cmd.CommandText = "INSERT INTO Futebol(Time) VALUES ('Barcelona');";

            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();

            Console.WriteLine("OK");
        
        
      
        /*
            SqlCommand cmd = new SqlCommand(){
                Connection = new SqlConnection();
            CommandText="";
        */

        
        }
    }
}
