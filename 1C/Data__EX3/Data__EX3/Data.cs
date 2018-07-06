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
        public void Adiciona()
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Digite o Dia");
                Dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Mes");
                Mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Ano");
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
        }
        public string EmTexto()
        {

            string data = String.Format("{0}/{1}/{2}", Dia, Mes, Ano);
            string dia = Convert.ToString(Dia);
            string mes = Convert.ToString(Mes);
            string ano = Convert.ToString(Ano);
            if (Dia < 10)
            {
                dia = String.Format("0{0}", Dia);
                data = String.Format("{0}/{1}/{2}", dia, Mes, Ano);
            }
            if (Mes < 10)
            {
                mes = String.Format("0{0}", Mes);
                data = String.Format("{0}/{1}/{2}", dia, mes, Ano);
            }
            if (Ano < 100 && Ano >= 10)
            {
                ano = String.Format("00{0}", Ano);
                data = String.Format("{0}/{1}/{2}", dia, mes, ano);
            }
            if (Ano < 10)
            {
                ano = String.Format("000{0}", Ano);
                data = String.Format("{0}/{1}/{2}", dia, mes, ano);
            }

            if (data == "0/0/0")
                return "Nao foi inserido uma data";
            else
                return data;
        }
        public string PorExtenso()
        {
            string data = "";
            if (Mes == 1)
                data = "Janeiro";
            else if (Mes == 2)
                data = "Fevereiro";
            else if (Mes == 3)
                data = "Março";
            else if (Mes == 4)
                data = "Abril";
            else if (Mes == 5)
                data = "Maio";
            else if (Mes == 6)
                data = "Junho";
            else if (Mes == 7)
                data = "Julho";
            else if (Mes == 8)
                data = "Agosto";
            else if (Mes == 9)
                data = "Setembro";
            else if (Mes == 10)
                data = "Outubro";
            else if (Mes == 11)
                data = "Novembro";
            else
                data = "Dezembro";
            data = String.Format("{0} de {1} de {2}", Dia, data, Ano);
            if (data == "0 de Dezembro de 0")
                return "Nao foi inserido uma data";
            else
                return data;
        }
        public void DiaSeguinte()
        {
            if (Dia == 31 && Mes == 1 || Dia == 31 && Mes == 3 || Dia == 31 && Mes == 5 || Dia == 31 && Mes == 7 || Dia == 31 && Mes == 8 || Dia == 31 && Mes == 10 || Dia == 31 && Mes == 12)
            {
                if (Mes == 12)
                {
                    Dia = 01;
                    Mes = 01;
                    Ano = Ano + 01;
                }
                else
                {
                    Dia = 01;
                    Mes = 03;
                }

            }
            else if (Dia == 28 && Mes == 2)
            {
                Dia = 01;
                Mes = 03;
            }
            else if (Dia == 30 && Mes == 4 || Dia == 30 && Mes == 6 || Dia == 30 && Mes == 9 || Dia == 30 && Mes == 11)
            {
                Dia = 01;
                Mes = Mes + 01;
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
                else if (Mes == 2)
                {
                    Dia = 31;
                    Mes = 01;
                }
                else if (Mes == 3)
                {
                    Dia = 28;
                    Mes = 02;
                }
                else if (Mes == 4)
                {
                    Dia = 31;
                    Mes = 03;
                }
                else if (Mes == 5)
                {
                    Dia = 30;
                    Mes = 04;
                }
                else if (Mes == 6)
                {
                    Dia = 31;
                    Mes = 05;
                }
                else if (Mes == 7)
                {
                    Dia = 30;
                    Mes = 06;
                }
                else if (Mes == 8)
                {
                    Dia = 31;
                    Mes = 07;
                }
                else if (Mes == 9)
                {
                    Dia = 31;
                    Mes = 08;
                }
                else if (Mes == 10)
                {
                    Dia = 30;
                    Mes = 09;
                }
                else if (Mes == 11)
                {
                    Dia = 31;
                    Mes = 10;
                }
                else if (Mes == 12)
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