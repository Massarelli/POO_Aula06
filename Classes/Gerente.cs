namespace POO_Aula06.Classes;

public class Gerente : Funcionario, ITrabalhavel
{
    public Gerente(string nome, decimal salario) : base(nome, salario) { }

    public override decimal CalcularBonus()
    {
        return Salario * 0.10m; // 10%
    }

    public void Trabalhar()
    {
        Console.WriteLine($"{Nome} está gerenciando a equipe e definindo metas.");
    }
}

