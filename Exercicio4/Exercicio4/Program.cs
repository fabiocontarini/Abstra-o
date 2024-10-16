using Exercicio4;

Carro carro1 = new Carro("Ford", "Mustang");
Carro carro2 = new Carro("Chevrolet", "Camaro");
Carro carro3 = new Carro("Volkswagen", "Fusca");

//aumenta e diminui a velocidade
carro1.Acelerar(300);
carro1.Desacelerar(70);

carro2.Acelerar(295);
carro2.Desacelerar(70);

carro3.Acelerar(75);
carro3.Desacelerar(45);

Console.ReadKey();
