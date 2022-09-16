string nome, sobrenome;
System.Console.Write("Digite o seu nome.....:");
nome = Console.ReadLine()!;

System.Console.Write("Digite seu sobrenome...");
sobrenome = Console.ReadLine()!;

System.Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Thread.Sleep(1000);
System.Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()} {nome}");