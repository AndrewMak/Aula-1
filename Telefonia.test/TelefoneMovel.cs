using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.test
{
    public class TelefoneMovel : Telefone
    {
        public decimal Min_Max { get; set; }

        public decimal Min_Usado { get; set; }

        public decimal Min_diferenca { get; set; }

        public decimal Valor_Min { get; set; }

        //metodo de cobranca
        public decimal Cobraca(TelefoneMovel telefone)
        {
            //se ultrapassar os minutos Maximo
            if (telefone.Min_Usado > telefone.Min_Max)
            {
                telefone.Min_diferenca = telefone.Min_Usado - telefone.Min_Max;

                telefone.Valor_Mensal = telefone.Valor_Mensal + (telefone.Min_diferenca * telefone.Valor_Min);
                return telefone.Valor_Mensal;
            }
            else
            {
                telefone.Valor_Mensal = telefone.Valor_Mensal;
                return telefone.Valor_Mensal;
            }
        }
    }
}
