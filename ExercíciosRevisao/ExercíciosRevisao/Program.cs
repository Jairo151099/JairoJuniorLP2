using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
           string modelo;
            double quilometragem, cavalos;

            Console.WriteLine("Informe o modelo do Carro");
            modelo = Console.ReadLine();

            Console.WriteLine("Informe a quilometragem do carro");
            quilometragem = double.Parse(Console.ReadLine());

          
       
           if (quilometragem <= 5000 )
            {
                Console.WriteLine(" O carro é novo");
            }
            else if (quilometragem > 5000 && quilometragem < 30000)
            {
                Console.WriteLine("O carro é seminovo");
            }
            
           else
           {
                Console.WriteLine("O carro é velho");
           }

           Console.WriteLine("Informe a quantidade de cavalos");
           cavalos = double.Parse(Console.ReadLine());

           if (cavalos > 200)
           {
               Console.WriteLine("O carro é potente");
           }

           else if (cavalos > 120 && cavalos < 200)
           {
               Console.WriteLine("O carro é forte");
           }

           else if (cavalos < 120)
           {
               Console.WriteLine("O carro é popular");
           }
        }
    }
}
