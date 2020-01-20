using System;
using System.Collections.Generic;
using System.Text;
using PatternFactory.Product;

namespace PatternFactory.ConcreteProduct
{
    class Bola : Produto
    {
        private string nome;
        private double preco;

        public Bola(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public override string Nome { get { return nome; } }
        public override double Preco { get { return preco; } set { preco = value; } }
    }
}
