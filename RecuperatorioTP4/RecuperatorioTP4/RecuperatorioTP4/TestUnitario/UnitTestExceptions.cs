using System;
using System.Collections.Generic;
using BibliotecaClases;
using EntidadesDAO;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
    [TestClass]
    public class UnitTestExceptions
    {
        [TestMethod]
        [ExpectedException(typeof(InstrumentoRepetidoException))]
        public void ProbarAltaInstrumentoRepetido()
        {
            Guitarra g = new Guitarra("test", "test", "test", 0, Guitarra.ETipoGuitarra.Acustica);
            Guitarra g2 = new Guitarra("test", "test", "test", 0, Guitarra.ETipoGuitarra.Acustica);

            InstrumentoDAO.Guardar(g);
            InstrumentoDAO.Guardar(g2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArchivoIncorrectoException))]
        public void ProbarDeserializacionVentasIncorrecta()
        {
            Bajo b = new Bajo("test", "test", "test", 0, Bajo.ETipoBajo.Activo);
            TiendaMusical t = new TiendaMusical();
            List<Venta> listaDeserializada;            

            bool agrega = t + b;                       
            t.Vender(b, "VentaTest.xml");
            listaDeserializada = t.RecuperarVenta("Rutaincorrecta.xml");
        }
    }
}







