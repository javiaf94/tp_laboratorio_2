using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;


        #region Constructores
        
        /// <summary>
        /// Inicializa los atributos estáticos de la clase.
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }

        /// <summary>
        /// Inicializa una instancia de la clase Profesor.
        /// </summary>
        public Profesor()
            : base()
        {
            ////Repeti unicamente este bloque de código para que serialize las clases del día de los profesores y cumplir con la consigna de mostrar todos los datos.
            this.clasesDelDia = new Queue<Universidad.EClases>(); 
            this._randomClases();
        }

        /// <summary>
        /// Inicializa una instancia de la clase Profesor. Con los valores pasados por parámetro.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        #endregion

        #region Métodos
        
        /// <summary>
        /// Asigna 2 clases aleatorias a la lista de clases del día.
        /// </summary>
        private void _randomClases()
        {
            clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(4));
            System.Threading.Thread.Sleep(300);
            clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(4));
        }

        /// <summary>
        /// Publica los datos del profesor
        /// </summary>
        /// <returns>Retorna una cadena con los datos del profesor</returns>
        protected override string MostrarDatos()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine(base.MostrarDatos());
            strBuild.AppendLine(this.ParticiparEnClase());

            return strBuild.ToString();
        }

        /// <summary>
        /// Publica los datos del profesor
        /// </summary>
        /// <returns>Retorna una cadena con los datos del profesor</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Simula participación en clase del Profesor.
        /// </summary>
        /// <returns>Retorna una cadena con las clases que dicta</returns>
        protected override string ParticiparEnClase()
        {            
            return $"CLASES DEL DÍA: \n{this.clasesDelDia.Peek()} \n{this.clasesDelDia.Last()}";
        }

        #endregion

        #region Operadores

        /// <summary>
        /// Verifica que el profesor dicte una clase.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna true si dicta la clase, false en caso contrario.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            foreach (Universidad.EClases c in i.clasesDelDia)
            {
                if (c == clase)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que el profesor no dicte la clase.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna true si dicta la clase, false en caso contrario</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    } 
}
