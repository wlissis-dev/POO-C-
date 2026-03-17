using System;
using ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        //COM O init  EU POSSO INICIALIZAR A RAÇA DO CACHORRO ASSIM TAMBÉM ALTERANDO
        Cachorro dog = new Cachorro("Rex", 100, "VIRA-LATA"){Raca = "Pitbull"};
        //SEM O set SÓ É PERMITIDO INICIALIZAR NO CONSTRUTOR
        //Cachorro dog = new Cachorro("Rex", 100, "VIRA-LATA");
        Console.WriteLine(dog.Nome); //aqui é o novo Get
        dog.Nome = "Simba"; //aqui é o novo Set
        Console.WriteLine(dog.Nome);
        //raça é uma propriedade imutável "init"
        //dog.Raca = "Mudando a Raça";//
        Console.WriteLine($"A RAÇA DO CACHORRO É: {dog.Raca} ");
        
        var cat = new Gato("Tom", 200, "Siamês");
        Console.WriteLine(cat.Nome); //aqui é o novo Get
        cat.Nome = "Chuck"; //aqui é o novo Set
        Console.WriteLine(cat.Nome);
       

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
