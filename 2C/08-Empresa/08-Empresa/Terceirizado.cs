using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Empresa
{
    class Terceirizado : Empregado
    {
        public string EmpresaMatriz { get; set; }

        public Terceirizado(int reg, string data, string empresa)
            : base(reg, data)
        {
            this.EmpresaMatriz = empresa;
        }
    }
}