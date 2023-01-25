using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViagemCarro
{
    public class Viagem
    {
        public string EnderecoAtual;
        public string destino;
        public string TipoDeCarro;
        
        public string MostrarDestino()
        {
            Console.WriteLine("Por Favor, Digite Seu Endereço de Destino: ");
            return destino;
        }
        
        public string EscolherCarro()
        {
            string Resposta;
            Console.WriteLine("Escolha o tipo de carro: 1 para FastCarComum e 2 para FastCarPremium.");
            Resposta = Console.ReadLine();
            {
                if (TipoDeCarro  == "1")
                {
                    TipoDeCarro = "Seu Carro escolhido Foi FastCarComum";
                }
                else
                {
                    TipoDeCarro = "Seu Carro escolhido foi FastCarPremium";
                }

                return TipoDeCarro;
            }
        }
        public string CancelarCorrida()
        {
           return "Que pena! Esperamos que a FastCar possa te ajudar da próxima vez!";
        }
        public string AceitarCorrida()
        {
            return "Obrigado por confiar na FastCar! Esperamos que faça uma Boa Viagem!";
                    
           
        }
    }
    
}