using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
   
 public class Venta
    {
        private DateTime fecha;
        private Instrumento instrumento;

        #region Constructores
        public Venta()
        {
        }

        /// <summary>
        /// Crea una nueva venta con la fecha y datos del instrumento.
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="instrumento"></param>
        public Venta(DateTime fecha, Instrumento instrumento)
        {
            this.fecha = fecha;
            this.instrumento = instrumento;
        }
        #endregion

        #region Propiedades
        public Instrumento Instrumento
        {
            get
            {
                return this.instrumento;
            }
            set
            {
                this.instrumento = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }
        #endregion

    }
}





