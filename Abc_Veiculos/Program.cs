using Abc_Veiculos.Modulo_veiculo;
using System.Security.Cryptography.X509Certificates;

//teste

namespace Abc_Veiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioVeiculo repositorio = new RepositorioVeiculo();

            TelaVeiculos veiculos = new TelaVeiculos(repositorio);
            Telaprincipal menuPrincipal = new Telaprincipal();



            while (true) {
            string opcaoEscolhida = menuPrincipal.MenuPrincipal();

                switch (opcaoEscolhida)
                {
                    case "1":
                        veiculos.Cadastrar_Veiculo();
                        break;

                    case "2":
                        veiculos.cadastrarDadosRevenda();
                        break;

                    case "3":
                        veiculos.cadastrarDadosRevenda();
                        break;

                }

            }
           



        }
    }
}
