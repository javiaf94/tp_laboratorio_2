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
            Guitarra g1 = new Guitarra("F123ASD3415", "Fender", "Telecaster Custom", 150000, Guitarra.ETipoGuitarra.Electrica);
            Guitarra g2 = new Guitarra("QWEaz321654", "Schecter", "Hellraiser", 650000, Guitarra.ETipoGuitarra.Electrica);
            Guitarra g3 = new Guitarra("12345aASJQ415", "Taylor", "GS Mini", 80000, Guitarra.ETipoGuitarra.Acustica);
            Bajo b1 = new Bajo("3216ASQwq65", "Fender", "Jazz Bass", 200000, Bajo.ETipoBajo.Pasivo);
            Bajo b2 = new Bajo("aSFKQOPWFAs", "Ernie Ball", "MusicMan", 300000, Bajo.ETipoBajo.Pasivo);

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
