using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T : new()
    {

        /// <summary>
        /// Guarda los datos de la clase T en un archivo XML, la ruta usada en el programa será /bin/debug
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo guardar el archivo, de lo contrario lanzará una excepción.</returns>
        public bool Guardar(string archivo, T datos)
        {
            XmlTextWriter writer = null;
            XmlSerializer serializer = null;
            try
            {
                writer = new XmlTextWriter(archivo, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, datos);
                return true;
            }
            catch (Exception ex)
            {
               throw new ArchivoIncorrectoException($"No pudo guardarse el archivo en la ruta especificada {archivo}.\n", ex);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Lee los datos de un archivo XMl especificado. la ruta usada en el programa será /bin/debug
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns>Retorna true si pudo leer el dato, de lo contrario lanzará una excepción</returns>
        public bool Leer(string archivo, out T datos)
        {

            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(archivo);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                datos = (T)serializer.Deserialize(reader);
                return true;
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException($"No pudo leerse el archivo en la ruta especificada {archivo}.\n", ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }


        }
    }
}
