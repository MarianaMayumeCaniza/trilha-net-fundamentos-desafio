using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIOESTACIONAMENTO.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

//O metodo a seguir estacionamento recebe os valores passados no sistema.

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }


        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Essa função é a opção numero 1 do menu estacionamento, devemos ler a entrada do teclado com a placa do veiculo

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            Console.WriteLine($"Veículo {veiculos[veiculos.Count - 1]} adicionado com sucesso!");


        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Essa é a segunda opção do meu menu, para remover a placa cadastrada
            string placa = Console.ReadLine();
            Console.WriteLine($"Verificando se a placa:{placa} consta no sistema. Aguarde um momento");

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Placa encontrada");
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                //Uma vez que a placa digitada for encontrada no sistema eu devo fazer o calculo das horas que esse veiculo ficou no estacionamento

                int horas = 0;
                decimal valorTotal = 0;


                if (int.TryParse(Console.ReadLine(), out horas)){
                    valorTotal = precoInicial + precoPorHora * horas;
                }else{
                    Console.WriteLine("Digite um valor inteiro para quantidade de horas.");
                }
                
                //horas = Convert.ToInt32(Console.ReadLine());
                //valorTotal = precoInicial + precoPorHora*horas;



                // TODO: Remover a placa digitada da lista de veículos
                // Uma vez que eu tenho meu valor total a ser pago eu removo o veiculo do meu sistema para que ele não apareça mais

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // Aqui é a 3ª opção do menu, mostrar todas as placas cadastradas no meu sistema
                int contadorveiculos = 0;
                foreach (string placas in veiculos){
                    Console.WriteLine($"Veículo Nº {contadorveiculos+1}: {placas}");
                    contadorveiculos++;
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}