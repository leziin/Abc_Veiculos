using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abc_Veiculos.Modulo_veiculo
{
    
    


   public class TelaVeiculos
    {
        public string ExibirMenu()
        {

            Console.WriteLine("---------------------");
            Console.WriteLine("Informe a opção desejada");

             string opcao = Console.ReadLine();

            return opcao;
            
        }





        public RepositorioVeiculo Repositioveiculo;

        public TelaVeiculos (RepositorioVeiculo repositorioVeiculo)
        {
            this.Repositioveiculo = repositorioVeiculo;
        }

        public void Cadastrar_Veiculo()
        {
            Veiculo NovoVeiculo = ObterDados_Veiculo();
            Repositioveiculo.CadastrarVeiculo(NovoVeiculo);


        }


        
        public Veiculo ObterDados_Veiculo()
        {
            Console.WriteLine("Informe a marca do veiculo");
            string marca = Console.ReadLine();


            Console.WriteLine("Informe o Modelo do Veiculo");
            string Modelo = Console.ReadLine();



            Console.WriteLine("Informe o Ano de fabricação do veiculo");
            DateTime Ano_Fabricacao = Convert.ToDateTime(Console.ReadLine());


            Veiculo NovoVeiculo = new Veiculo(marca, Modelo, Ano_Fabricacao);
            return NovoVeiculo;
        }


    }
}
