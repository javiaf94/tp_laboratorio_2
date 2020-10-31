using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        ///  Instancia una exception del tipo NacionalidadInvalidaException.
        /// </summary>
        public NacionalidadInvalidaException()
            : base()
        {
        }

        /// <summary>
        /// Instancia una exception del tipo NacionalidadInvalidaException, recibiendo un mensaje personalizado por parametro. 
        /// </summary>
        /// <param name="message"></param>
        public NacionalidadInvalidaException(string message)
            : base(message)
        {
        }

    }
}
