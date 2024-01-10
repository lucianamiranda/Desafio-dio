using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DESAFIO.Modelos
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial,decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){

            Console.WriteLine("Digite a placa do veiculo para estacionar");
            string placa = Console.ReadLine();

            Veiculos.Add(placa);


        }

        public void RemoverVeiculo(){
           
            Console.WriteLine("Digite a placa do carro para remover");
            
            string placa = Console.ReadLine();

    

            if(Veiculos.Any(x => x.ToUpper() == placa.ToUpper())){

                  Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                  int horas = Convert.ToInt16(Console.ReadLine());
                     
        
                  decimal valorTotal = precoInicial + precoPorHora * horas;

                 Console.WriteLine($"O veículo {placa} foi removido e o preço total foi : R${valorTotal}");

            } else
            {
                Console.WriteLine("Desculpe,esse veículo não está estacionado aqui.Confira se digitou corretamente.");
            }

        }

        public void ListarVeiculos(){

            if(Veiculos.Any())
            
            {

                 foreach (var item in Veiculos)
                 {
                    Console.WriteLine($"Os veículos estacionados são: {item} ");
 
                 }

            } 
            
            else{
                Console.WriteLine("Não há veículos estacionados");
            }

        }
    }
}