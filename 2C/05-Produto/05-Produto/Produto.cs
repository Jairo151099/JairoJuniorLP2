using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Produto
{
    class Produto
    {
        private int id;

        public int Id
        {
            get { return id; }
        }
        public string Nome { get; set; }

        private int quatidade;

        public int Quantidade
        {
            get { return quatidade; }
        }
        public double Preco { get; set; }

        public void Repor(int repor)
        {
            this.quatidade += repor;
        }

        public Produto(int id, string nome, int preco)
        {
            this.id = id;
            this.Nome = nome;
            this.Preco = preco;
            this.quatidade = 0;
        }
    }
}