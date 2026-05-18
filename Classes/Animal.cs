namespace POO_Aula06.Classes
{
    // public class Animal
    // {
    //     public virtual void EmitirSom()
    //     {
    //         Console.WriteLine("O animal emite um som.");
    //     }
    // }


    public abstract class AnimalAbstrato
    {
        private string Nome;
        public AnimalAbstrato (string nome)
        {
            Nome = nome;
        }
        public void Dormir()
        {
            Console.WriteLine("O animal está dormindo.");
        }
        public abstract void EmitirSom();
    }
}