using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Conversor
    {
     public static double KgParaG(double k)
        {
            return k * 1000;
        }
        public static double KgParaT(double k)
        {
            return k * 1000;
        }
        public static double KgParaLb(double k)
        {
            return k * 2.2;
        }
        public static double GParaKg(double g)
        {
            return g/1000;
        }
        public static double TParaKg(double t)
        {
            return t / 1000;
        }
        public static double LbParaKg(double l)
        {
            return l / 2.2;
        }
        public static double CParaFh(double c)
        {
            return (c * 0.55) + 32;
        }
        public static double CParaK(double c)
        {
            return c + 273;
        }
        public static double FhParaC(double f)
        {
            return (f - 32) * 0.55;
        }
        public static double FhParaK(double f)
        {
            return Conversor.FhParaC(f) + 273;
        }
        public static double KParaC(double k)
        {
            return k - 273;
        }
        public static double KParaFh(double k)
        {
            return (k - 273) * 1.8 + 32;
        }

        public static double MParaKm(double m)
        {
            return m * 1000;
        }
        public static double MParaP(double m)
        {
            return m * 3.2808;
        }

        public static double MParaPol(double m)
        {
            return m * 39.370;
        }

        public static double KmParaM(double km)
        {
            return km/1000;
        }

        public static double KmParaMil(double km)
        {
            return km * 0.621;
        }

        public static double MilParaKm(double mil)
        {
            return mil/0.621;
        }

        public static double PolParaM(double pol)
        {
            return pol/39.370;
        }

        public static double PolParaP(double pol)
        {
            return pol / 0.083;
        }

        public static double PParaM(double p)
        {
            return p / 3.280;
        }

        public static double PParaPol(double p)
        {
            return p * 0.083;
        }