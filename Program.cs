string nome, sobrenome;
Console.WriteLine("Digite seu nome......: ");
nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenonome......: ");
sobrenome = Console.ReadLine();

Console.WriteLine($"{nome} {sobrenome}");
Console.Write($"{sobrenome.ToUpper()}, {nome}");