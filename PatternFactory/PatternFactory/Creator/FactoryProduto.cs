using System;
using System.Collections.Generic;
using System.Text;
using PatternFactory.Product;

namespace PatternFactory.Creator
{
    abstract class FactoryProduto
    {
        public abstract Produto getProduto();
    }
}
