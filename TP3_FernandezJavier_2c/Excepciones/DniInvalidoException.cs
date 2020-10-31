using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {

        /// <summary>
        /// Instancia una exception del tipo DniInvalidoException.
        /// </summary>
        public DniInvalidoException()
            :base()
        {
        }

        /// <summary>
        /// Instancia una exception del tipo DniInvalidoException. Anidando una excepcion recibida como parámetro
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e)
            : base(typeof(DniInvalidoException).Name, e)
        {
        }

        /// <summary>
        /// Instancia una exception del tipo DniInvalidoException. Recibiendo un mensaje personalizado como parametro.
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Instancia una exception del tipo DniInvalidoException. Anidando una excepcion recibida como parámetro y recibiendo un mensaje personalizado.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="e"></param>
        public DniInvalidoException(string message, Exception e)
            : base(message, e)
        {
        }



    }
}
