using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trabalho_Exercicio2
{
    class Elevador
    {
        public int AndarAgora;
        public int Andares;
        public double Total;
        public int QuantidadeDePessoas;

        public void Entra(int quantidade)
        {
            if (Total <= QuantidadeDePessoas + quantidade)
                QuantidadeDePessoas += quantidade;
        }
        public void Sai(int quantidade)
        {
            if (QuantidadeDePessoas > 0)
                QuantidadeDePessoas = QuantidadeDePessoas - 1;
        }
        public void Vai()
        {
            if (AndarAgora < Andares)
                AndarAgora += 1;
        }
        public void Emergencia()
        {
            Console.WriteLine("Ligando para o Corpo de Bombeiros (193)");
            Console.Beep(3000, 100);
            Thread.Sleep(125);
            Console.Beep(3000, 100);
            Thread.Sleep(125);
            Console.Beep(3000, 100);


        }

    }
}