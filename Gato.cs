namespace ConsoleApp1;

public class Gato : Animal, ITreinavel
{
    private string _raca;
    public string Raca
    {
        get { return _raca; }
        set { _raca = !string.IsNullOrWhiteSpace(value) ? value : "Gato generico" ; }
    }
    
    public Gato(string nome, int idade, string raça) : base(nome, idade)
    {
    }
    public  void ExecutarTruque()
    {
        Console.WriteLine($"{Nome} esta fazendo o truque de rolagem");   
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"O gato {Nome} da Raça {Raca} está dizando : Miu Miu!");
    }
}