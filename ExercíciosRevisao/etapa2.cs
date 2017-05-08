using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int veic;
            string modelo;
            double km, pot;
            string classifRodagem, classifPot;

            Console.WriteLine("informe a quantidade de carros");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {


                Console.WriteLine("Informe o modelo");
                modelo = Console.ReadLine();

                Console.WriteLine("Informe a quilometragem");
                km = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a potencia");
                pot = double.Parse(Console.ReadLine());

 
                if (km <= 5000)
                    classifRodagem = "novo";
                else if (km <= 30000)
                    classifRodagem = "semi novo";
                else
                    classifRodagem = "velho";

            if (pot > 200)
                classifPot = "potente";
            else if (pot < 200 && pot > 120)
                classifPot = "forte";
            else
                classifPot = "popular";     
            Console.WriteLine("{0} - {1} - {2}", modelo, classifRodagem, classifPot);     
            }
          

            

        }
    }
}
