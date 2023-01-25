using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppViagemCarro
{
    public class Aplicativo
    {
        public string NomeAPP;
        public string NomeUsuario;

        public string MostrarNomeApp()
        {
            NomeAPP = "FastCar";
            return $"Seja Bem Vindo Ao {NomeAPP}!";
        }

            public string ConfirmarNomeUsuario()
        {
            string Resposta;
                      
                Console.WriteLine("Digite seu Nome de Usuário: "); 
                NomeUsuario = Console.ReadLine();
                          
            return $"Seja Bem vindo ao FastCar {NomeUsuario}";
           
           
        }

        public string MostrarNomeUsuario()
        {
            return NomeUsuario;
        }


    }
}