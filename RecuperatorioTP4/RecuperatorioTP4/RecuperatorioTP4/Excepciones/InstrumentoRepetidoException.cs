using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class InstrumentoRepetidoException : Exception
    {
        public InstrumentoRepetidoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {
        }

        public InstrumentoRepetidoException(string mensaje)
            : base(mensaje)
        {
        }

    }
}
