using Desafio2SistemaMedico;

Pessoa pessoa1 = new Pessoa();

pessoa1.nome = "Beatriz Oliveira";
pessoa1.idade = 23;
pessoa1.altura = 1.61;
pessoa1.peso = 73;

Console.WriteLine($"Nome: {pessoa1.nome}\nIdade: {pessoa1.idade} anos\nAltura: {pessoa1.altura}m\nPeso: {pessoa1.peso} kg");

Console.ReadKey();
