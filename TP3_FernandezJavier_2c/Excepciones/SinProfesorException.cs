using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {
        /// <summary>
        /// Instancia una exception del tipo SinProfesorException.
        /// </summary>
        public SinProfesorException()
            : base()
        {            
        }

        /// <summary>
        /// Instancia una exception del tipo SinProfesorException, recibiendo un mensaje personalizado por parametro. 
        /// </summary>
        /// <param name="mensaje"></param>
        public SinProfesorException(string mensaje) //constructor no incluido en el diagrama de clases, pero necesaria para cumplir con el enunciado.
            : base (mensaje)
        {
        }

    }
}
