using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        /*Dado que el PDF pide que se serializen todos los datos, agregué esta propiedad unicamente para poder
          serializar los legajos. Ya que al leerlos los devolvía en su valor por defecto.*/
        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }


        #region Constructores
        /// <summary>
        /// Inicializa una instancia de Universitario
        /// </summary>
        public Universitario()
            : base()
        {
        }

        /// <summary>
        /// Inicializa una instancia de Universitario, con los valores pasados por parámetro.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        
        #endregion

        #region Métodos

        /// <summary>
        /// Verifica que el objeto pasado por parametro sea del tipo Universitario
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>devuelve True en caso afirmativo, False en caso contrario</returns>
        public override bool Equals(object obj)
        {
            return (obj is Universitario);
        }

        /// <summary>
        /// Publica los datos del Universitario.
        /// </summary>
        /// <returns>Retorna una cadena con los datos del Universitario</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine(base.ToString());
            strBuild.AppendLine($"LEGAJO NÚMERO: {this.legajo}");
            
            return strBuild.ToString();
        }

        protected abstract string ParticiparEnClase();
        #endregion

        #region Operadores

        /// <summary>
        /// Valida que dos Universitarios sean iguales, según su legajo o dni.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>Retorna true si Legajo o Dni son iguales, false en caso contrario</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
        //Como ambos son universitarios no es necesario validarlo utilizando Equals.
            return (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI); 
        }

        /// <summary>
        /// Valida que dos Universitarios sean distintos, según su legajo o dni.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>Retorna False si Legajo o Dni son iguales, True en caso contrario</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        #endregion
    
    }
}
