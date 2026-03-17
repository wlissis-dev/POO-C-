namespace ConsoleApp1;

public class Cachorro : Animal, ITreinavel
{
    public string Raca { get; set; }

    // Construtor passando dados para a classe base (base)
    public Cachorro(string nome, int idade, string raca) : base(nome, idade)
    {
        Raca = raca;
    }

    // Sobrescrita (Override): Mudando o comportamento do método da base
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} diz: Au Au!");
    }

    // Implementação da Interface
    public void ExecutarTruque()
    {
        Console.WriteLine($"{Nome} deu a pata e fingiu de morto!");
    }
}