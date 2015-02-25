using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia.test
{
    public abstract class Telefone
    {
        public int Tipo { get; set; }

        public int DDD { get; set; }

        public int Numero { get; set; }

        public decimal Valor_Mensal { get; set; }
    }
}
