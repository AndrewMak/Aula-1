using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.test
{
    public class TelefoneFixo : Telefone
    {
        public int Qtd_Pulso { get; set; }

        public int Qtd_PulsoMax { get; set; }

        public int Qtd_PulsoTotal { get; set; }

        public decimal Valor_Pulso { get; set; }

        //metodo de cobranca
        public decimal Cobraca(TelefoneFixo telefone)
        {
            telefone.Valor_Mensal = telefone.Valor_Mensal + (telefone.Qtd_Pulso * telefone.Valor_Pulso);
            return telefone.Valor_Mensal;
        }
    }
}
