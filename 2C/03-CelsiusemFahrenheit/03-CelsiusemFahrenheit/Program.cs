using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            TemperaturaCelsius a = new TemperaturaCelsius();
            while (true)
            {
                Console.WriteLine("1 - Nova Temperatura");
                Console.WriteLine("2 - Para Fahrenheit");
                Console.WriteLine("3 - Para Kelvin");
                Console.WriteLine("0 - Sair");
                x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    a.valor = double.Parse(Console.ReadLine());
                }
                if (x == 2)
                {
                    Console.WriteLine(a.convertF());
                }
                if (x == 3)
                {
                    Console.WriteLine(a.convertK());
                }
                if (x == 0)
                {
                    break;
                }

            }
        }
    }
}