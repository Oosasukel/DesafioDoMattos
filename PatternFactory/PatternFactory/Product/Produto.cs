using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFactory.Product
{
    abstract class Produto
    {
        public abstract string Nome { get; }
        public abstract double Preco { get; set; }
    }
}
