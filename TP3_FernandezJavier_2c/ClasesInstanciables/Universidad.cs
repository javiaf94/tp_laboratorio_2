using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad 
    {
        public enum EClases { Programacion, Laboratorio, Legislacion, SPD }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                if(this.jornada.Count > i)
                    this[i] = value;
            }
        }

        /// <summary>
        /// Inicializa una instancia de Universidad.
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

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

        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Publica los datos de una Universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Retorna los datos de una universidad </returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine("UNIVERSIDAD - JORNADAS");
            foreach (Jornada j  in uni.Jornadas)
            {
                strBuild.AppendLine(j.ToString());
            }
            
            strBuild.AppendLine("UNIVERSIDAD - ALUMNOS");
            foreach (Alumno a  in uni.Alumnos)
            {
                strBuild.AppendLine(a.ToString());
            }

            strBuild.AppendLine("UNIVERSIDAD - PROFESORES");
            foreach (Profesor p in uni.Instructores)
            {
                strBuild.AppendLine(p.ToString());
            }
            
            return strBuild.ToString();
        }
        
        /// <summary>
        /// Publica los datos de la Universidad
        /// </summary>
        /// <returns>Retorna una cadena con los datos de la Universidad</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        /// <summary>
        /// Serializa y guarda los datos de una Universidad en formato XML. El archivo será guardado en rutadelproyecto\Consola\bin\debug\Universidad.xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>Retorna true si pudo guardar el archivo. Arrojará una excepción en caso contrario</returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> guardarXml = new Xml<Universidad>();
            try
            { 
                return guardarXml.Guardar("Universidad.xml", uni);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Lee los datos de una universidad de un archivo XML. Buscará el archivo en rutadelproyecto\Consola\bin\debug\Universidad.xml
        /// </summary>
        /// <returns>Retorna una Universidad con los datos leidos, si pudo leer el archivo. De lo contrario arrojará una excepción</returns>
        public static Universidad Leer()
        {
            Universidad auxUni = new Universidad();
            try
            {
                Xml<Universidad> leerXml = new Xml<Universidad>();
                leerXml.Leer("Universidad.xml", out auxUni);
                return auxUni;
            }
            catch
            {
                throw;
            }
        }


        #endregion

        #region Operadores

        /// <summary>
        /// Verifica que el alumno forme parte de la lista de inscriptos
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>true si está en la lsita, false en caso contrario</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.alumnos)
            {
                if (alumno == a)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que un alumno no esté en la lista de inscriptos
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns>true si no está inscripto. False en caso contrario</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Verifica que el profesor se encuentre en la lista de instructores
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>true si se encuentra en la lista, false en caso contrario</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor prof in g.profesores)
            {
                if (prof == i)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que el profesor no se encuentre en la lista de instructores
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns>true si no se encuentra en la lista, false en caso contrario</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        
        /// <summary>
        /// Devuelve el primer profesor de la lista que pueda dar la clase
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>Devuelve un profesor que de la clase, o una excepción en caso de no existir nadie habilitado</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {            
            foreach (Profesor p in g.profesores)
            {
                if(p == clase)                
                    return p;                                    
            }
            throw new SinProfesorException($"No hay profesor disponible para la clase de {clase}");
        }
            
        /// <summary>
        /// Devuelve el primer profesor de la lista que pueda dar la clase.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns>Devuelve un profesor que no pueda dar la clase. En caso de que todos los profesores puedan, arroja una excepción</returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor p  in u.profesores)
            {
                if (p != clase)
                    return p;
            }
            throw new SinProfesorException($"Todos los profesores pueden dar la clase de {clase}");
        }

        /// <summary>
        /// Agrega una jornada con el primer profesor habilitado para dar la clase, la clase, y todos los alumnos que tomen la misma.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>Devuelve una Universidad con la Jornada agregada. De no existir profesor arrojará una excepción</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            try
            {
                Profesor prof = (g == clase);
                Jornada jornada = new Jornada(clase, prof);
                
                List<Alumno> alumnosAux = new List<Alumno>();
                foreach (Alumno alumno in g.alumnos)
                {
                    if (alumno == clase)
                        alumnosAux.Add(alumno);
                }
                jornada.Alumnos = alumnosAux;

                g.Jornadas.Add(jornada);
                return g;
            }
            catch(SinProfesorException)
            {
                throw;
            }
        }


        /// <summary>
        /// Agrega un alumno a la lista de inscriptos, siempre que sea posible.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns>Devuelve la universidad con el alumno agregado. De encontrarse repetido arrojará una excepción</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.alumnos.Add(a);
                return u;
            }
            throw new AlumnoRepetidoException("El Alumno se encuentra repetido");

        }
        
        /// <summary>
        /// Agrega un profesor a la universidad, siempre que no se encuentre agregado previamente.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns>Devuelve la universidad, con el profesor agregado si es que no estaba repetido</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
                u.profesores.Add(i);
            return u;
        }
        #endregion

    }
}
