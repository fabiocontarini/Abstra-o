namespace Exercicio2
{
    internal class Aluno
    {
        public int RM { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Nascimento { get; set; }

        public Aluno(int rm, string nome, string email, string nascimento)
        {
            RM = rm;
            Nome = nome;
            Email = email;
            Nascimento = nascimento;
        }
        public void sala1()
        {
            Console.WriteLine($"\nEsse aluno estuda na sala do 2° ano do E.M!");
        }
        public void sala2()
        {
            Console.WriteLine($"\nEsse aluno estuda na sala do 2° ano do E.M!");
        }
        public void sala3()
        {
            Console.WriteLine($"\nEsse aluno estuda na sala do 2° ano do E.M!");
        }
    }
}

