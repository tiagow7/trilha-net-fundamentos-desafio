namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // Verifique se a placa já está na lista antes de adicionar
            if (!veiculos.Contains(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Veículo com placa {placa} já está na lista.");
            }


        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                veiculos.Remove(placa);
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int hora = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + precoPorHora * hora;

                Console.WriteLine($"O veículo {placa} foi removido.\nPreço total foi de: R${valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"Os veículos estacionados são: {veiculo}");
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
