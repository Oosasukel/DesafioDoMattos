using System;
using PatternFactory.ConcreteCreator;
using PatternFactory.Creator;
using PatternFactory.Product;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryProduto factory = null;
            Console.WriteLine("Qual produto você quer criar?\nOpções: Bola.");
            string op = Console.ReadLine();

            switch (op.ToLower())
            {
                case "bola":
                    factory = new FactoryBola("Bola de basquete", 70);
                    break;
                default:
                    Console.WriteLine("Não temos {0}. Então vamos criar uma Bola.", op);
                    factory = new FactoryBola("Bola de basquete", 70);
                    break;
            }

            Produto produto = factory.getProduto();
            Console.WriteLine("\nDetalhes do seu produto: \n");
            Console.WriteLine("Nome do produto: {0}\nPreço: {1}", produto.Nome, produto.Preco);
        }
    }
}
