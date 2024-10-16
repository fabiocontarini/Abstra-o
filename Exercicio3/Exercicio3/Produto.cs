namespace Exercicio3
{
    internal class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public string Estoque { get; set; }


        public Produto(int codigo, string nome, double preco, string estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
        public void estoque1()
        {
            Console.WriteLine($"\nTemos 90 unidades de refrigerante em nosso estoque.");
        }
        public void estoque2()
        {
            Console.WriteLine($"\nO suco se encontra indisponível em nosso estoque.");
        }
        public void estoque3()
        {
            Console.WriteLine($"\nTemos 29 unidades de acholatado em nosso estoque.");
        }
    }
}
