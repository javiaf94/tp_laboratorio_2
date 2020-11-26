using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;


namespace BibliotecaClases
{
    public class TiendaMusical
    {
        private List<Instrumento> instrumentos;
        private List<Venta> ventas;
        
        public TiendaMusical()
        {
            this.instrumentos = new List<Instrumento>();
            this.ventas = new List<Venta>();
        }
        
        
        public List<Instrumento> Instrumentos
        {
            get
            {
                return this.instrumentos;
            }
            set
            {
                this.instrumentos = value;
            }
        }

        public static bool operator +(TiendaMusical t , Instrumento i)
        {
            if(t != i)
            {
                t.instrumentos.Add(i);
                return true;
            }
            else
            {
                throw new InstrumentoRepetidoException("Ese instrumento ya está en la lista");
            }
        }

        public static bool operator ==(TiendaMusical t, Instrumento i)
        {
            foreach (Instrumento instrumento in t.instrumentos)
            {
                if(i == instrumento)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(TiendaMusical t, Instrumento i)
        {
            return !(t == i);
        }

        /// <summary>
        /// Agrega una venta a la lista y serializa en XML todas las ventas realizadas.
        /// </summary>
        /// <param name="i"></param>
        public void Vender(Instrumento i, string ruta)
        {
            Venta venta = new Venta(DateTime.Now, i);
            Xml<List<Venta>> xml = new Xml<List<Venta>>();
            this.ventas.Add(venta);
            xml.Guardar(ruta, this.ventas);
        }

        public List<Venta> RecuperarVenta(string ruta)
        {
            List<Venta> lista;
            Xml<List<Venta>> xml = new Xml<List<Venta>>();
            xml.Leer(ruta, out lista);
            return lista;
        }
                
    }
}
