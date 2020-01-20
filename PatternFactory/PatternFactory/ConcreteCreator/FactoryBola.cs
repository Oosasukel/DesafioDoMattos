using System;
using System.Collections.Generic;
using System.Text;
using PatternFactory.ConcreteProduct;
using PatternFactory.Creator;
using PatternFactory.Product;

namespace PatternFactory.ConcreteCreator
{
    class FactoryBola : FactoryProduto
    {
        private string nome;
        private double preco;

        public FactoryBola(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
        }
        public override Produto getProduto()
        {
            return new Bola(nome, preco);
        }
    }
}
