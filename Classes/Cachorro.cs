namespace POO_Aula06.Classes;

// public class Cachorro : Animal
// {
//     public override void EmitirSom()
//     {
//         Console.WriteLine("O cachorro late: Au Au!");
//     }
// }

public class CachorroAbstrato : AnimalAbstrato
{
    public CachorroAbstrato(string nome) : base(nome)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late: Au Au!");
    }
}