using Exercicio2;

Aluno aluno1 = new Aluno(2671, "Fábio Contarini", "fabio.contarini@portalsesisp.org.br", "5/3/2008");
Console.WriteLine("\nO RM do aluno(a) é: " + aluno1.RM);
Console.WriteLine("O nome do aluno(a): " + aluno1.Nome);
Console.WriteLine("O E-mail do aluno(a) é: " + aluno1.Email);
Console.WriteLine("O ano de nascimento do aluno(a) é: " + aluno1.Nascimento);
aluno1.sala1();

Aluno aluno2 = new Aluno(2014, "Larissa Oliveira de Santana", "larissa.santana3@portalsesisp.org.br", "3/6/2008");
Console.WriteLine("\nO RM do aluno(a) é: " + aluno2.RM);
Console.WriteLine("O nome do aluno(a): " + aluno2.Nome);
Console.WriteLine("O E-mail do aluno(a) é: " + aluno2.Email);
Console.WriteLine("O ano de nascimento do aluno(a) é: " + aluno2.Nascimento);
aluno2.sala1();

Aluno aluno3 = new Aluno(2006, "José Eduardo dos santos Barbosa", "jose.eduardo@portalsesisp.org.br", "31/3/2008");
Console.WriteLine("\nO RM do aluno(a) é: " + aluno3.RM);
Console.WriteLine("O nome do aluno(a): " + aluno3.Nome);
Console.WriteLine("O E-mail do aluno(a) é: " + aluno3.Email);
Console.WriteLine("O ano de nascimento do aluno(a) é: " + aluno3.Nascimento);
aluno3.sala3();

Console.ReadKey();