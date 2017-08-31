using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CódigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Condificar. \n2 - Decodificar");

            int op = int.Parse(Console.ReadLine());
            Mensagem m = new Mensagem();
            m.Texto = Console.ReadLine();

            if (op == 1)
                Console.WriteLine(m.Codificar());
            else if (op == 2)
                Console.WriteLine(m.Decodificar());
            else
                Console.WriteLine("Inválido");

        }
    }
}