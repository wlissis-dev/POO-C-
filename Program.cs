using System;
using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Cachorro dog = new Cachorro("Rex", 100, "Pitbull");
        Console.WriteLine(dog.Nome); //aqui é o novo Get
        dog.Nome = "Simba"; //aqui é o novo Set
        Console.WriteLine(dog.Nome);
        dog.EmitirSom();
        dog.ExecutarTruque();
        
        var cat = new Gato("Tom", 200, "Siamês");
        Console.WriteLine(cat.Nome); //aqui é o novo Get
        cat.Nome = "Chuck"; //aqui é o novo Set
        Console.WriteLine(cat.Nome);
        cat.EmitirSom();
        cat.ExecutarTruque();

        List <Animal> meusPets = new List<Animal>();
        meusPets.Add(dog);
        meusPets.Add(cat);

        
        //Dica: Lembre-se que ExecutarTruque está na interface ITreinavel, mas nem
        // ..TTodo Animal assinou esse contrato.
        foreach (var pet  in meusPets)
        {
            pet.EmitirSom();
            //pet.ExecutarTruque(); por isso gera esse ERRO
        }
        foreach (var pet in meusPets)
        {
            // 2. Apenas quem é ITreinavel faz truque (Filtragem por Interface)
            if (pet is ITreinavel petTreinavel)
            {
                // O C# já converte o 'animal' para 'animalCapazDeTruque' aqui dentro
                petTreinavel.ExecutarTruque();
                
            }
            else
            {
                Console.WriteLine($"{pet.Nome} não sabe fazer truques ainda.");
            }
        }
    }
}
