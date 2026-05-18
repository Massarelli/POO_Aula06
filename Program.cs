using POO_Aula06.Classes;
using System; // Garante o acesso a List e Console

// ==========================================
// TESTES ANTERIORES (Calculadora e Animais)
// ==========================================

Calculadora calculadora = new Calculadora();
var resultado2inteiros = calculadora.Somar(10, 20);
var resultado3inteiros = calculadora.Somar(10, 20, 30);
var resultado2doubles = calculadora.Somar(10.5, 20.3);

Console.WriteLine("Resultados das somas:");
Console.WriteLine($"Resultado da soma de 2 inteiros: {resultado2inteiros}");
Console.WriteLine($"Resultado da soma de 3 inteiros: {resultado3inteiros}");
Console.WriteLine($"Resultado da soma de 2 doubles: {resultado2doubles}");

Console.WriteLine("\n-----------------------------\n");
CachorroAbstrato lilica = new CachorroAbstrato("Lilica");
GatoAbstrato harry = new GatoAbstrato("Harry");
lilica.EmitirSom();
harry.EmitirSom();

Passaro passaro = new Passaro();
passaro.Voar();

Console.WriteLine("\n-----------------------------\n");
TV tv = new TV();
tv.Ligar();
VideoGame videoGame = new VideoGame();
videoGame.Ligar();
ArCondicionado arCondicionado = new ArCondicionado();
arCondicionado.Ligar();


// ==========================================
// NOVO: SISTEMA DE FUNCIONÁRIOS
// ==========================================
Console.WriteLine("\n-----------------------------\n");
Console.WriteLine("=== SISTEMA DE FUNCIONÁRIOS ===\n");

Gerente gerente = new Gerente("Alice Silva", 12000.00m);
Desenvolvedor dev = new Desenvolvedor("Bruno Souza", 7500.00m);
Estagiario estagiario = new Estagiario("Caio Lima", 2000.00m);

List<Funcionario> funcionarios = new List<Funcionario> { gerente, dev, estagiario };

// "Para cada 'func' dentro da lista 'funcionarios'..."
foreach (var func in funcionarios)
{
    Console.WriteLine($"Funcionário: {func.Nome}");
    Console.WriteLine($"Salário Base: {func.Salario:C}");
    Console.WriteLine($"Bônus Recebido: {func.CalcularBonus():C}");
    Console.WriteLine($"Salário Total: {(func.Salario + func.CalcularBonus()):C}");

    if (func is ITrabalhavel trabalhador)
    {
        trabalhador.Trabalhar();
    }

    Console.WriteLine(new string('-', 40));
}

Console.ReadLine();