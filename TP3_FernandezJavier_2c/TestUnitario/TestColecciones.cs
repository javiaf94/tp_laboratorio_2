using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using EntidadesAbstractas;
using Excepciones;
using System.Collections.Generic;

namespace TestUnitario
{
    [TestClass]
    public class TestColecciones
    {
        [TestMethod]
        public void TestInstanciaColecionesUniversidad()
        {
            Universidad uni = new Universidad();

            Assert.IsInstanceOfType(uni.Instructores, typeof(List<Profesor>));
            Assert.IsNotNull(uni.Instructores);
        }
    }
}
