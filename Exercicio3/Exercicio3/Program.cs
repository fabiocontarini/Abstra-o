using Exercicio3;

Produto produto1 = new Produto(883456710, "Refrigerante", 3.99, "Disponível");
Console.WriteLine("\nO código do produto é: " + produto1.Codigo);
Console.WriteLine("Produto: " + produto1.Nome);
Console.WriteLine("O preço a cada kilo é de: " + produto1.Preco);
Console.WriteLine("Em estoque: " + produto1.Estoque);
produto1.estoque1();

Produto produto2 = new Produto(90987627, "Suco", 6.99, "Indisponível");
Console.WriteLine("\nO código do produto é: " + produto2.Codigo);
Console.WriteLine("Produto: " + produto2.Nome);
Console.WriteLine("O preço a cada kilo é de: " + produto2.Preco);
Console.WriteLine("Em estoque: " + produto2.Estoque);
produto2.estoque2();

Produto produto3 = new Produto(280876584, "acholatado", 5.00, "Disponível");
Console.WriteLine("\nO código do produto é: " + produto3.Codigo);
Console.WriteLine("Produto: " + produto3.Nome);
Console.WriteLine("O preço a cada kilo é de: " + produto3.Preco);
Console.WriteLine("Em estoque: " + produto3.Estoque);
produto3.estoque3();

Console.ReadKey();
