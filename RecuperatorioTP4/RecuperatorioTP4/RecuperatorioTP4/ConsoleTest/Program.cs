using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClases;
using EntidadesDAO;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Guitarra g1 = new Guitarra("G12305423", "Gibson", "Les Paul", 300000, Guitarra.ETipoGuitarra.Electrica);
            Guitarra g2 = new Guitarra("A12124828", "Fender", "Stratocaster", 850000, Guitarra.ETipoGuitarra.Electrica);
            Guitarra g3 = new Guitarra("ISSJQ415", "Ibanez", "EC100", 70000, Guitarra.ETipoGuitarra.Acustica);
            Bajo b1 = new Bajo("F29331991", "Fender", "P-Bass", 200000, Bajo.ETipoBajo.Pasivo);
            Bajo b2 = new Bajo("X01238412", "Gibson", "Hummingbird", 300000, Bajo.ETipoBajo.Activo);

            InstrumentoDAO.Guardar(g1);
            InstrumentoDAO.Guardar(g2);
            InstrumentoDAO.Guardar(g3);
            InstrumentoDAO.Guardar(b1);
            InstrumentoDAO.Guardar(b2);

            Console.WriteLine(g1.ToString());
            Console.WriteLine(g2.ToString());
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());

            TiendaMusical t = new TiendaMusical();
            t.Instrumentos = InstrumentoDAO.LeerInstrumentos();
            foreach (Instrumento instrumento in t.Instrumentos)
            {
                Console.WriteLine(instrumento.ToString());
            }


            g3.Marca = "Anderson";
            InstrumentoDAO.Modificar(g3);

            Bajo b3 = new Bajo("aSFKQOPWFAs", "cambiado", "cambiado", 50, Bajo.ETipoBajo.Activo);
            InstrumentoDAO.Modificar(b3);


            Console.ReadKey();
        }

    }
}
