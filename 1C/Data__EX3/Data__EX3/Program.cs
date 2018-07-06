using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Data data = new Data();
            while (i == 0)
            {
                Console.WriteLine("[0] - Sair\n[1] - Adicionar Data\n[2] - Mostrar data no Formato dd/mm/yyyy\n[3] - Mostrar data por Extenso\n[4] - Avançar um dia\n[5] - Regredir um dia");
                try
                {
                    int op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        data.Adiciona();
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine(data.EmTexto());
                    }
                    else if (op == 3)
                    {
                        Console.WriteLine(data.PorExtenso());
                    }
                    else if (op == 4)
                    {
                        data.DiaSeguinte();

                    }
                    else if (op == 5)
                    {
                        data.DiaAnterior();
                    }
                    else if (op == 0)
                    {
                        i = 2;
                    }
                    else
                    {
                        Console.WriteLine("Opcao nao existente");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Algo deu errado\nTenta Novamente Campeao");
                }

            }

        }
    }
}