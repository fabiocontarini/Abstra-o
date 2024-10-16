namespace Exercicio1
{
    internal class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int AnoDeLancamento { get; set; }

        public Livro(string titulo, string autor, string editora, int anodelancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            AnoDeLancamento = anodelancamento;
        }
        public void Recomenda1()
        {
            Console.WriteLine($"\nEsse livro é incrivel (Jogos vorazes)");
        }
        public void Recomenda2()
        {
            Console.WriteLine($"\nEsse livro é incrivel (Jogos vorazes)");
        }
        public void Recomenda3()
        {
            Console.WriteLine($"\nEsse livro é incrivel (Jogos vorazes)");
        }
    }
}
