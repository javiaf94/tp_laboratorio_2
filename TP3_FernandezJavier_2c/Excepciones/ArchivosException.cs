using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Instancia una exception del tipo ArchivosException.
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException)
            : base( typeof(ArchivosException).Name , innerException)
        {
        }

        /// <summary>
        /// Instancia una exception del tipo ArchivosException, recibiendo un mensaje personalizado por parametro.
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public ArchivosException(string mensaje, Exception innerException)  //constructor no incluido en el diagrama de clases, pero necesaria para cumplir con el enunciado.
            : base(mensaje, innerException)
        {
        }

    }
}
