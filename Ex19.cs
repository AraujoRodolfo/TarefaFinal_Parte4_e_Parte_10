string p1, p2;

Console.Write("Digite o nome da pessoa 1: ");
p1 = Console.ReadLine();

Console.Write("Digite o nome da pessoa 2: ");
p2 = Console.ReadLine();

Console.WriteLine(p1.ToUpper() + " & " +  p2.ToUpper());
Console.WriteLine(p1.Length + " & " +  p2.Length + " < quantidade de caracteres");
Console.WriteLine(p1.Substring(0, 3) + " & " +  p2.Substring(0, 3) + " < 3 primeiros caracteres");