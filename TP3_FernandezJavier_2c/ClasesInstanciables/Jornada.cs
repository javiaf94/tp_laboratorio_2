using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        
        #region Constructores
        
        /// <summary>
        /// Inicializa una instancia de la clase Jornada.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Inicializa una instancia de la clase Jornada, con los valores recibidos por parámetro.
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Propiedades
        
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Guarda los datos de la Jornada en el archivo "Jornadas.txt". Se guardará en la ruta del proyecto\Consola\bin\debug. De existir el archivo anexará la información.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns>Retornará true si pudo guardar los datos, de lo contrario arrojará una excepción</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto txt = new Texto();
            try
            {
                return txt.Guardar("Jornadas.txt", jornada.ToString());
            }
            catch(ArchivosException)
            {
                throw;
            }

        }

        /// <summary>
        /// Lee los datos del archivo de jornadas "Jornadas.txt". Lo buscará en la ruta del proyecto\Consola\bin\debug
        /// </summary>
        /// <returns>Retorna los datos del archivo si pudo leerlo. De lo contrario arrojará una excepción</returns>
        public static string Leer()
        {
                Texto txt = new Texto();
                string datosLeidos;
            try
            {
                txt.Leer("Jornadas.txt", out datosLeidos);
                return datosLeidos;
            }
            catch(ArchivosException)
            {
                throw;
            }
        }
            
        /// <summary>
        /// Publica los datos de una jornada.
        /// </summary>
        /// <returns>Devuelve una cadena con todos los datos de la Jornada</returns>
        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine("JORNADA:");
            strBuild.Append($"CLASE DE: {this.clase} POR ");
            strBuild.AppendLine(this.instructor.ToString());
            strBuild.AppendLine("ALUMNOS:");
            foreach (Alumno a in this.alumnos)
            {
                strBuild.AppendLine(a.ToString());
            }
            strBuild.AppendLine("<------------------------------------------------>");
            return strBuild.ToString();
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Verifica que el alumno participe de la jornada.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si particia, false en caso contrario</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach (Alumno alumno in j.alumnos)
            {
                if (alumno == a)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica que el alumno no participe en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si no participa, false en caso contrario</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        
        /// <summary>
        /// Agrega un alumno a la jornada, siempre que no se encuentre repetido.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns>Si el alumno cumple con el criterio es agregado. Finalmente retorna la jornada</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.alumnos.Add(a);
            return j;
        }
        #endregion
    }
}
