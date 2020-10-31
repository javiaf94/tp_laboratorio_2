using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using EntidadesAbstractas;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class TestExceptiones
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAgregaAlumnos()
        {
            Alumno a1 = new Alumno(100, "Juan", "Perez", "38381010", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno a2 = new Alumno(150, "Roberto", "Gomez", "38381010", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);
            Universidad uni = new Universidad();

            uni += a1;
            uni += a2;

        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestPersonaDniInvalido()
        {
            Alumno a = new Alumno(102, "Laura", "Aguirre", "-12345", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestPersonaNacionalidadInvalido()
        {
            Profesor p = new Profesor(1001, "Julian", "Laje", "28103254", Persona.ENacionalidad.Extranjero);
        }
    }
}
