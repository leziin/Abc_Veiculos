using Abc_Veiculos.Modulo_veiculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abc_Veiculos
{
 public static class Gerador_Id
    {
        public static int IdVeiculo = 0;
            

    public static int GerarIdVeiculo ()
        {
            IdVeiculo++;

            return IdVeiculo;
           
        }
    }


}
