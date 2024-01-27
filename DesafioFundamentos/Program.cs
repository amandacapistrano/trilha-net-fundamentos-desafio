using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  "Digite o preço inicial do estacionamento:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    System.Console.WriteLine("#######################################################");
    System.Console.WriteLine("##               Sistema estacionamento              ##");
    System.Console.WriteLine("#######################################################");
    System.Console.WriteLine($"Preço: {precoInicial:C} + {precoPorHora:C} por hora.\n");
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Histórico de veículos removidos");
    Console.WriteLine("5 - Encerrar");


    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();
            es.AdicionarVeiculo();
            break;

        case "2":
            Console.Clear();
            es.RemoverVeiculo();
            break;

        case "3":
            Console.Clear();
            es.ListarVeiculos();
            break;
        
        case "4":
            Console.Clear();
            es.HistoricoVeiculos();
            break;

        case "5":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
