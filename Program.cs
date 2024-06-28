// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Screen Sound";

void PrintMensagem()
{
    Console.WriteLine(mensagemBoasVindas);    
}

void PrintMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média");
    Console.WriteLine("Digite -1 para sair\n");

    Console.Write("Digite uma opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch(opcao)
    {
        case 1: 
            Console.WriteLine("Opcao 1");
            break;
        case 2: 
            Console.WriteLine("Opcao 2");
            break;
        case 3: 
            Console.WriteLine("Opcao 3");
            break;
        case 4: 
            Console.WriteLine("Opcao 4");
            break;
        case -1:
            Console.WriteLine("Encerrando programa");
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }
}

PrintMensagem();
PrintMenu();
