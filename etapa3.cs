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
       int i, n, pot;
       string modelo;
       double km; 

Console.WriteLine("Informe a quantidade de carros");
n = Convert.ToInt32(Console.ReadLine());

    for (i = 0; i < n; i++)
    {
        Console.WriteLine("Informe o nome do carro");
        modelo = Console.ReadLine();

	Console.WriteLine("Informe a quilometragem do carro");
        km = double.Parse(Console.ReadLine());
       
	Console.WriteLine("Informe a potencia do carro");
	pot = int.Parse(Console.ReadLine());

        Console.WriteLine(Classificar(modelo, km, pot));
              
    }
 }

        public static string Classificar(string modelo, double km, int pot)
        {
            string classifRodagem,classifPot, P;

            if (km <= 5000)
                classifRodagem = "novo";

            else if (km <= 30000)
                classifRodagem = "seminovo";

            else
                classifRodagem = "velho";

            if (pot < 120)
                classifPot = "popular";

            else if (pot <= 200)
                classifPot = "forte";

            else
                classifPot = "potente";

            return String.Format("{0} - {1} - {2}", modelo, classifRodagem, classifPot);

        }
    }
}
