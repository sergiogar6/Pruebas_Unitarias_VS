using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarIngresoNegativo()
        {
            double saldoInicial = 1000;
            double ingresoNegativo = -500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingresoNegativo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarReintegroNegativo()
        {
            double saldoInicial = 1000;
            double reintegroNegativo = -500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegroNegativo);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarReintegroMayorQueSaldo()
        {
            double saldoInicial = 1000;
            double reintegroExcesivo = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarReintegro(reintegroExcesivo);
        }
    }
}
