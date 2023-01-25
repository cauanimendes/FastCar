using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViagemCarro
{
    public class Informações
    {
        public string EnderecoAtual;
        public string destino;

       
        public string ConfirmarEndereçoAtual()
        {
                               
                    Console.WriteLine($"Por favor digite seu endereço atual: ");
                    EnderecoAtual = Console.ReadLine();


                   return "";

           
             
           
        }
        public string ConfirmarDestino()
        {
                       
                    Console.WriteLine($"Por favor confirme seu endereço de destino: ");
                    destino = Console.ReadLine();

                   return "";           
        }
    };
};