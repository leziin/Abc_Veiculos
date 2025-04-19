using Abc_Veiculos.compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc_Veiculos.Modulo_veiculo
{
   public class Veiculo : EntidadeBase
    {
       
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano_Fabricacao { get; set; }

        public Veiculo(string marca, string modelo, DateTime ano_fabricacao)
        {
            Marca = marca;
            Modelo = modelo;
            Ano_Fabricacao = ano_fabricacao;


        }
    }
}
