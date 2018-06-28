using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Exercicio3
{
    class Data
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public string EmTexto()
        {
            int i = 0;
            while (i == 0)
            {
                Dia = int.Parse(Console.ReadLine());
                Mes = int.Parse(Console.ReadLine());
                Ano = int.Parse(Console.ReadLine());
                int cont = 0;
                if (Dia <= 0 || Dia > 31)
                    cont = 1;
                else if (Mes == 2 && Dia > 28)
                {
                    cont = 1;
                }
                else if (Mes == 1 && Dia > 31 || Mes == 3 && Dia > 31 || Mes == 5 && Dia > 31 || Mes == 7 && Dia > 31 || Mes == 8 && Dia > 31 || Mes == 10 && Dia > 31 || Mes == 12 && Dia > 31)
                {
                    cont = 1;
                }
                else if (Mes == 4 && Dia > 30 || Mes == 6 && Dia > 30 || Mes == 9 && Dia > 30 || Mes == 11 && Dia > 30)
                {
                    cont = 1;
                }
                else if (Mes <= 0 || Mes > 12)
                {
                    cont = 1;
                }
                else if (Ano <= 0)
                {
                    cont = 1;
                }
                string data = String.Format("{0}/{1}/{2}", Dia, Mes, Ano);
                if (cont == 1)
                    Console.WriteLine("A data {0} não é valida\n Tente Novamente", data);
                else
                    i = 1;
            }
            return String.Format("{0}/{1}/{2}", Dia, Mes, Ano);
        }
        public string PorExtenso()
        {
            int i = 0;
            while (i == 0)
            {
                Dia = int.Parse(Console.ReadLine());
                Mes = int.Parse(Console.ReadLine());
                Ano = int.Parse(Console.ReadLine());
                int cont = 0;
                if (Dia <= 0 || Dia > 31)
                    cont = 1;
                else if (Mes == 2 && Dia > 28)
                {
                    cont = 1;
                }
                else if (Mes == 1 && Dia > 31 || Mes == 3 && Dia > 31 || Mes == 5 && Dia > 31 || Mes == 7 && Dia > 31 || Mes == 8 && Dia > 31 || Mes == 10 && Dia > 31 || Mes == 12 && Dia > 31)
                {
                    cont = 1;
                }
                else if (Mes == 4 && Dia > 30 || Mes == 6 && Dia > 30 || Mes == 9 && Dia > 30 || Mes == 11 && Dia > 30)
                {
                    cont = 1;
                }
                else if (Mes <= 0 || Mes > 12)
                {
                    cont = 1;
                }
                else if (Ano <= 0)
                {
                    cont = 1;
                }
                string data = String.Format("{0}/{1}/{2}", Dia, Mes, Ano);
                if (cont == 1)
                    Console.WriteLine("A data {0} não é valida\n Tente Novamente", data);
                else
                    i = 1;
            }

            string mesporextenso = "";
            if (Mes == 1)
                mesporextenso = "Janeiro";
            else if (Mes == 2)
                mesporextenso = "Fevereiro";
            else if (Mes == 3)
                mesporextenso = "Março";
            else if (Mes == 4)
                mesporextenso = "Abril";
            else if (Mes == 5)
                mesporextenso = "Maio";
            else if (Mes == 6)
                mesporextenso = "Junho";
            else if (Mes == 7)
                mesporextenso = "Julho";
            else if (Mes == 8)
                mesporextenso = "Agosto";
            else if (Mes == 9)
                mesporextenso = "Setembro";
            else if (Mes == 10)
                mesporextenso = "Outubro";
            else if (Mes == 11)
                mesporextenso = "Novembro";
            else
                mesporextenso = "Dezembro";

            return String.Format("{0} de {1} de {2}", Dia, mesporextenso, Ano);
        }
        public void DiaSeguinte()
        {
            if (Dia == 31 && Mes == 1 || Dia == 31 && Mes == 3 || Dia == 31 && Mes == 5 || Dia == 31 && Mes == 7 || Dia == 31 && Mes == 8 || Dia == 31 && Mes == 10 || Dia == 31 && Mes == 12)
            {
                if (Mes == 12)
                {
                    Dia = 1;
                    Mes = 1;
                    Ano = Ano + 1;
                }
                else
                {
                    Dia = 1;
                    Mes = 3;
                }

            }
            else if (Dia == 28 && Mes == 2)
            {
                Dia = 1;
                Mes = 3;
            }
            else if (Dia == 30 && Mes == 4 || Dia == 30 && Mes == 6 || Dia == 30 && Mes == 9 || Dia == 30 && Mes == 11)
            {
                Dia = 1;
                Mes = Mes + 1;
            }
            else
                Dia += 1;

        }
        public void DiaAnterior()
        {
            if (Dia == 1)
            {
                if (Mes == 1)
                {
                    if (Ano > 1)
                    {
                        Dia = 31;
                        Mes = 12;
                        Ano = Ano - 1;
                    }
                    else
                        Console.WriteLine("Não foi possivel");

                }
                if (Mes == 2)
                {
                    Dia = 31;
                    Mes = 1;
                }
                if (Mes == 3)
                {
                    Dia = 28;
                    Mes = 2;
                }
                if (Mes == 4)
                {
                    Dia = 31;
                    Mes = 2;
                }
                if (Mes == 5)
                {
                    Dia = 30;
                    Mes = 4;
                }
                if (Mes == 6)
                {
                    Dia = 31;
                    Mes = 5;
                }
                if (Mes == 7)
                {
                    Dia = 30;
                    Mes = 6;
                }
                if (Mes == 8)
                {
                    Dia = 31;
                    Mes = 7;
                }
                if (Mes == 9)
                {
                    Dia = 31;
                    Mes = 8;
                }
                if (Mes == 10)
                {
                    Dia = 30;
                    Mes = 9;
                }
                if (Mes == 11)
                {
                    Dia = 31;
                    Mes = 10;
                }
                if (Mes == 12)
                {
                    Dia = 30;
                    Mes = 11;
                }
            }
            else
                Dia = Dia - 1;

        }
    }
}