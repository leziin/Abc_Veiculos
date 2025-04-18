using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc_Veiculos
{
    public class Telaprincipal
    {
        public string MenuPrincipal()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Informe a Opção escolhida");
            Console.WriteLine("---------------------");
            Console.WriteLine("1- Menu Veiculos");

            string opcao = Console.ReadLine();
            return opcao;

        }

    }
}
