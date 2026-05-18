namespace POO_Aula06.Classes;

public class Estagiario : Funcionario, ITrabalhavel
{
    public Estagiario(string nome, decimal salario) : base(nome, salario) { }

    public override decimal CalcularBonus()
    {
        return Salario * 0.01m; // 1%
    }

    public void Trabalhar()
    {
        Console.WriteLine($"{Nome} está aprendendo, tirando dúvidas e buildando o projeto.");
    }
}