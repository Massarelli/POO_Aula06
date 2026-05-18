namespace POO_Aula06.Classes;
public class Desenvolvedor : Funcionario, ITrabalhavel
{
    public Desenvolvedor(string nome, decimal salario) : base(nome, salario) { }

    public override decimal CalcularBonus()
    {
        return Salario * 0.05m; // 5%
    }

    public void Trabalhar()
    {
        Console.WriteLine($"{Nome} está codificando e transformando café em software.");
    }
}