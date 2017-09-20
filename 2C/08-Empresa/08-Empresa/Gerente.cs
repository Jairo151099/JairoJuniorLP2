using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Empresa
{
    class Gerente : Funcionario
    {
        public string Setor { get; set; }
        public double Bonus { get; set; }

        public Gerente(int reg, string setor)
            : base(reg)
        {
            this.Setor = setor;
        }

    }
}