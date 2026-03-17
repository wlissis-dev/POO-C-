namespace ConsoleApp1.Models;

//ESSA É UMA CLASSE ABSTRATA = NÃO PODE SER INSTANCIADA
//ANIMAL É ALGO GENERICO COM CARACTERISTICAS COMUNS
//A VARIAS OUTRAS CLASSES
public abstract class Animal
{
    // Encapsulamento: Propriedade com lógica de proteção
    private string _nome;
    public string Nome 
    { 
        get => _nome; 
        set => _nome = !string.IsNullOrWhiteSpace(value) ? value : "Animal Genérico"; 
    }

    //essas duas formas de trabalhar são válidas
    private int _idade;
    public int Idade
    {
        get { return _idade; }
        set { if (value > 0) _idade = value; }
    }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    // Método Virtual: Permite que as classes filhas o sobrescrevam (Polimorfismo)
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal emite um som vago.");
    }
}
