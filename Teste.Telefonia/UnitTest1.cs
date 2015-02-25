using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telefonia.test;

namespace Teste.Telefonia
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CobracaTelefoneMovel_ultrapassa()
        {
            TelefoneMovel telefone = new TelefoneMovel();
            telefone.Min_Max = 100;
            telefone.Min_Usado = 120;
            telefone.Valor_Mensal = 80;
            telefone.Valor_Min = 1.2M;
            Assert.AreEqual(telefone.Cobraca(telefone), 104);
        }

        [TestMethod]
        public void CobracaTelefoneMovel_Nao_ultrapassa()
        {
            TelefoneMovel telefone = new TelefoneMovel();
            telefone.Min_Max = 100;
            telefone.Min_Usado = 80;
            telefone.Valor_Mensal = 80;
            telefone.Valor_Min = 1.2M;
            Assert.AreEqual(telefone.Cobraca(telefone), 80);
        }



        [TestMethod]
        public void CobracaTelefoneFixo() 
        {
            TelefoneFixo telefone = new TelefoneFixo();
            telefone.Qtd_Pulso = 120;
            telefone.Valor_Mensal = 30;
            telefone.Valor_Pulso = 1.3M;
            Assert.AreEqual(telefone.Cobraca(telefone),186 );
        }

       
    }
}
