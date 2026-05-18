using POO_Aula06.Classes;

// Cachorro lilica = new Cachorro();
// Gato harry = new Gato();

// lilica.EmitirSom();
// harry.EmitirSom();

// Calculadora calculadora = new Calculadora();
// var resultado2inteiros = calculadora.Somar(10,20);
// var resultado3inteiros = calculadora.Somar(10,20,30);
// var resultado2doubles = calculadora.Somar(10.5,20.3);


// Console.WriteLine($"Resultado da soma de 2 inteiros: {resultado2inteiros}");
// Console.WriteLine($"Resultado da soma de 3 inteiros: {resultado3inteiros}");
// Console.WriteLine($"Resultado da soma de 2 doubles: {resultado2doubles}");

CachorroAbstrato lilica = new CachorroAbstrato("Lilica");
GatoAbstrato harry = new GatoAbstrato("Harry");
lilica.EmitirSom();
harry.EmitirSom();
