namespace ConsoleApp1;

public class Cachorro : Animal, ITreinavel
{
    //como faríamos para que a Raca do cachorro
    //pudesse ser definida apenas na criação e nunca mais alterada?
    //IMUTABILIDADE
    
    //public string Raca { get; set; }
    //por que não tirar apenar o set? Porque ele vai ser obrigrado a inicializar a raça no construtor
    
    // Trocamos 'set' por 'init'
    public string Raca { get; init; }

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
