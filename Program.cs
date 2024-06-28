// Screen Sound
using System.ComponentModel;

string mensagemBoasVindas = "Boas vindas ao Screen Sound";

//List<string> bandas = ["Bump of Chicken", "Kessoku Band"];

// var bandas = new Dictionary<string, List<int>>{ 
//     { "teste", [1, 2] },
//     { "teste2" , [3]},
// };
// var bandas = new Dictionary<string, List<int>> { 
//     ["a"] = [1, 2], //no caso é um dicionario com string e lista, por isso os valores (1 e 2) estao em colchetes
//     ["b"] = [3],
// };

var bandas = new Dictionary<string, List<int>> {
    ["Bump of Chicken"] = [10, 9, 8],
    ["Kessoku Band"] = [10, 10, 10]
};

void PrintMensagem(string mensagem)
{
    Console.Clear();
    Console.WriteLine(mensagem);
    Console.WriteLine();
}

void VoltandoParaMenu()
{
    Console.Write("\nPressiona uma tecla para voltar ao menu ");
    Console.ReadKey();
    Console.Clear();
    PrintMensagem("Voltando para o menu...");
    Thread.Sleep(1500);
    PrintMenu();
}

void RegistrarBanda()
{
    PrintMensagem("Registro de bandas");

    Console.Write("Digite o nome da Banda: ");
    string nome = Console.ReadLine()!;

    Console.WriteLine($"A banda {nome} foi cadastrada com sucesso");
    bandas.Add(nome, []);

    VoltandoParaMenu();
}

void PrintBandas(Boolean withIndex = false)
{
    int index = 0;

    foreach(string banda in bandas.Keys)
    {
        if(withIndex)
        {
            Console.Write($"{index} - ");
            index++;
        }
        Console.WriteLine($"Banda: {banda}");
    }
}

void ListarBandas()
{
    PrintMensagem("Listando bandas:");

    PrintBandas();

    VoltandoParaMenu();
}

void AvaliarBanda()
{
    PrintMensagem("Qual banda avaliar?");

    PrintBandas(true);

    Console.Write("\nIndice da banda: ");
    int index = int.Parse(Console.ReadLine()!);

    var banda = bandas.ElementAt(index);

    Console.WriteLine($"\nBanda: {banda.Key}");
    Console.Write("Nota para a banda: ");
    int nota = int.Parse(Console.ReadLine()!);

    banda.Value.Add(nota);

    Console.WriteLine($"Nota {nota} adicionada para a banda {banda.Key}");

    VoltandoParaMenu();
}

void MediaNotaBanda()
{
    PrintMensagem("Media de qual banda?");

    PrintBandas(true);

    Console.Write("\nIndice da banda: ");
    int index = int.Parse(Console.ReadLine()!);

    var banda = bandas.ElementAt(index);

    if(banda.Value.Count == 0)
    {
        Console.WriteLine($"Nao ha notas para a banda {banda.Key}");
    } else {
        float media = (float)banda.Value.Average();
        Console.WriteLine($"Media de notas da banda {banda.Key}: {media}");
    }

    VoltandoParaMenu();
}

void PrintMenu()
{
    PrintMensagem(mensagemBoasVindas);

    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média");
    Console.WriteLine("Digite 0 para sair\n");

    Console.Write("Digite uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch(opcao)
    {
        case 1: 
            RegistrarBanda();
            break;
        case 2: 
            ListarBandas();
            break;
        case 3: 
            AvaliarBanda();
            break;
        case 4: 
            MediaNotaBanda();
            break;
        case 0:
            Console.WriteLine("Encerrando programa");
            break;
        default:
            Console.WriteLine("Opcao invalida");
            VoltandoParaMenu();
            break;
    }
}

PrintMenu();