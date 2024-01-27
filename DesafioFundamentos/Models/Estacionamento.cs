namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
    
        private List<string> veiculos = new List<string>();

        private Stack<string> historicoVeiculos = new Stack<string>();


        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string novoVeiculo = Console.ReadLine().ToUpper();
            if(veiculos.Contains(novoVeiculo)){
                System.Console.WriteLine("Verifique sua digitação! A placa já está no sistema!");
            }else{
                veiculos.Add(novoVeiculo);
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
             if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas; 

                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*
                    veiculos.Remove(placa.ToUpper());
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
                    historicoVeiculos.Push($"Placa: {placa} - Valor pago:{valorTotal:C} ");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }


        public void HistoricoVeiculos()
        {
            System.Console.WriteLine("Histórico dos últimos veículos estacionados:");
            if(historicoVeiculos.Any()){
                foreach (var veiculo in historicoVeiculos)
                {
                    System.Console.WriteLine(veiculo);
                }
            }else{
                System.Console.WriteLine("Sem histórico de veículos!");
            }
           
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in veiculos){
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
