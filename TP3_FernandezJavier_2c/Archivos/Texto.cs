using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda la cadena de caracteres pasada por parametro en la ruta especificada
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo guardarse la información. De lo contrario arrojará una excepción</returns>
        public bool Guardar(string archivo, string datos)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(archivo, true);
                writer.Write(datos);
                return true;
            }
            catch(Exception ex)
            {
                throw new ArchivosException($"No pudo guardarse el archivo de en la ruta especificada {archivo}.\n", ex);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

                
        /// <summary>
        /// Lee los datos del archivo especificado.
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si puedo leer el archivo. De lo contrario lanzará una excepción</returns>
        public bool Leer(string archivo, out string datos)
        {
            StreamReader reader = null;            
            try
            {
                reader = new StreamReader(archivo);
                datos = reader.ReadToEnd();
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivosException($"No pudo leerse el archivo de en la ruta especificada {archivo}.\n", ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
    }
}
