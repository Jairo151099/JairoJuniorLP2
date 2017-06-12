using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            /* O tipo Objeto2D não existirá até que você crie uma nova 
             * classe para representá-lo em seu projeto!*/
            Objeto2D obj = new Objeto2D();

            /* Inicialização da posição do objeto */
            obj.X = x;
            obj.Y = y;

            Console.Write("Digite comando: ");
            ConsoleKey comando = Console.ReadKey().Key;

            /* O while abaixo só funcionará corretamente caso a 
             * classe Objeto2D tenha sido construida de forma adequada, 
             * ou seja, que saiba realizar as tarefas de andar para a direita 
             * e de retornar uma string exibindo suas coordenadas */
            while (comando != ConsoleKey.Escape)
            {
                if (comando == ConsoleKey.RightArrow)
                    obj.MoverParaDireita();

                Console.WriteLine(obj.Coordenadas());

                Console.Write("Digite comando: ");
                comando = Console.ReadKey().Key;
            }
        }
    }
}