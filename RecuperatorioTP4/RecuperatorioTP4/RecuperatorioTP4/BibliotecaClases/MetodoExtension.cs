using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public static class MetodoExtension
    {
        /// <summary>
        /// Realiza un formato del precio para mostrarse correctamente por pantalla
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public static string FormatearPrecio(this float precio)
        {
            return "$" + precio.ToString("n2");
        }
    }
}
