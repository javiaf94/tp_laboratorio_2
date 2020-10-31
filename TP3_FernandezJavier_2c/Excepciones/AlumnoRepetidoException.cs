using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        /// <summary>
        /// Instancia una exception del tipo AlumnoRepetidoException.
        /// </summary>
        public AlumnoRepetidoException()
            : base()
        {
        }

        /// <summary>
        /// Instancia una exception del tipo AlumnoRepetidoException, recibiendo un mensaje personalizado por parametro. 
        /// </summary>
        /// <param name="mensaje"></param>
        public AlumnoRepetidoException(string mensaje) //constructor no incluido en el diagrama de clases, pero necesaria para cumplir con el enunciado.
            : base(mensaje)
        {
        }

    }
}
