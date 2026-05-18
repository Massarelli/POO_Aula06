namespace POO_Aula06.Classes;

// public class Gato : Animal
// {
//     public override void EmitirSom()
//     {
//         Console.WriteLine("O gato mia: Miau!");
//     }
// }

public class GatoAbstrato : AnimalAbstrato
{
    public GatoAbstrato(string nome) : base(nome)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("O gato mia: Miau!");
    }
}