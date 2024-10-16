namespace Exercicio4
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; private set; }

        public Carro(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = 0; //comeco a vlcd no 0
        }

        public void Acelerar(int mais)
        {
            Velocidade += mais;
            Console.WriteLine($"\nO carro {Marca} {Modelo} acelerou para {Velocidade} km/h.");
        }

        public void Desacelerar(int menos)
        {
            Velocidade -= menos;
            if (Velocidade < 0) Velocidade = 0;
            Console.WriteLine($"O carro {Marca} {Modelo} desacelerou para {Velocidade} km/h.");
        }

    }
}
