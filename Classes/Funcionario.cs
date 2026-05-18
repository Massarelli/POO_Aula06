namespace POO_Aula06.Classes;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public decimal Salario { get; set; }

    // Construtor para garantir que todo funcionário tenha nome e salário
    protected Funcionario(string nome, decimal salario)
    {
        Nome = nome;
        Salario = salario;
    }

    // Método abstrato que DEVE ser implementado pelas classes filhas
    public abstract decimal CalcularBonus();
}