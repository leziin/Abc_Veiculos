using Abc_Veiculos.compartilhado;

namespace Abc_Veiculos.Modulo_veiculo
{
   public class Veiculo : EntidadeBase
    {
       
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano_Fabricacao { get; set; }

        public Veiculo(string marca, string modelo, string ano_fabricacao)
        {
            Marca = marca;
            Modelo = modelo;
            Ano_Fabricacao = ano_fabricacao;


        }
    }
}
