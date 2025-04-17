using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc_Veiculos.Modulo_veiculo;

public class RepositorioVeiculo
{
    public Veiculo[] veiculos = new Veiculo[1000];
    public   int contadorVeiculo = 0;


    public void CadastrarVeiculo(Veiculo NovoVeiculo)
    {
        NovoVeiculo.Id = Gerador_Id.GerarIdVeiculo();
        veiculos[contadorVeiculo++] = NovoVeiculo;

    }
}

