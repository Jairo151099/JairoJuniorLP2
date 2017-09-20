using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Empresa
{
    class Empregado : Funcionario
    {
        public string Gerente { get; set; }
        public string Entrada { get; set; }
        public Gerente gente { get; set; }

        public Empregado(int reg, string data)
            : base(reg)
        {
            this.Entrada = data;
        }


    }
}