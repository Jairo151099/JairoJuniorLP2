using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        
       struct carro
        {
            public int potencia;
            public int qtd;
            public string nome;
            public double km;
            
        static void Main(string[] args)
        {
            carro automovel;
            int i;

            Console.WriteLine("Informe a quantidade de carros");
            automovel.qtd = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < automovel.qtd; i++)
            {
                Console.WriteLine("Informe o nome do carro");
                automovel.nome = Console.ReadLine();

	            Console.WriteLine("Informe a quilometragem do carro");
                automovel.km = double.Parse(Console.ReadLine());
       
	            Console.WriteLine("Informe a potencia do carro");
                automovel.potencia = int.Parse(Console.ReadLine());

                Console.WriteLine(Classificar(automovel.nome, automovel.km, automovel.potencia));
              
            }
        } //static void main

    public static string Classificar(string modelo, double km, int pot)
    {          
        string classifRodagem, classifPot;

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
}
