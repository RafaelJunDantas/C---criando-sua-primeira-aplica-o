// List<String> list = ["C#", "Java", "JavaScript"];

// foreach (string s in list)
// {
//     Console.WriteLine(s);
// }

// Console.Write("Digite um inteiro: ");
// int num = int.Parse(Console.ReadLine()!);

// if(num > list.Count)
// {
//     Console.WriteLine("Indice invalido");
// } else {
//     Console.WriteLine($"{list[num]}");
// }

Random rand = new Random();
int randNum = rand.Next(1, 101);

int num = 0;

Console.WriteLine("Adivinhe o numero entre 1 e 100");
while(num != randNum)
{
    Console.Write("Numero: ");
    num = int.Parse(Console.ReadLine()!);

    if(num == randNum)
    {
        Console.WriteLine($"Voce acertou, o numero era {randNum}");
        break;
    }

    if(num > randNum)
    {
        Console.WriteLine($"{num} > randNum");
    } else {
        Console.WriteLine($"{num} < randNum");
    }
}