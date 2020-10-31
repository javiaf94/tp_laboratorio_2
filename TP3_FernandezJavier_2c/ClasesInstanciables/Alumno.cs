using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{    
    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta { AlDia, Deudor, Becado}
        
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;      

        #region Constructores
        
        /// <summary>
        /// Se inicializa una instancia de Alumno
        /// </summary>
        public Alumno() 
        {
        }

        /// <summary>
        /// Inicializa una instancia de Alumno, con los valores pasados por parámetro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad,  Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Inicializa una instancia de Alumno, con los valores pasados por parámetro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Simula participación en clase del alumno.
        /// </summary>
        /// <returns>Retorna una cadena con la clase que toma</returns>
        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASE DE: {this.claseQueToma}";
        }

        /// <summary>
        /// Publica los datos del Alumno.
        /// </summary>
        /// <returns>Retorna cadena con los datos del alumno</returns>
        protected override string MostrarDatos()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine(base.MostrarDatos());
            switch(this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    strBuild.AppendLine($"ESTADO DE CUENTA: Cuota al día");
                    break;
                case EEstadoCuenta.Becado:
                    strBuild.AppendLine($"ESTADO DE CUENTA: Alumno becado");
                    break;
                case EEstadoCuenta.Deudor:
                    strBuild.AppendLine($"ESTADO DE CUENTA: Alumno debe cuotas");
                    break;
            }
            strBuild.AppendLine(this.ParticiparEnClase());

            return strBuild.ToString();
        }

        /// <summary>
        /// Publica los datos del alumno.
        /// </summary>
        /// <returns>Retorna cadena con los datos del alumno</returns>
        public override string ToString()
        {        
            return this.MostrarDatos();           
        }
        #endregion

        #region Operadores
        
        /// <summary>
        /// Verifica que el alumno no tome la clase pasada por parametros.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna true si no toma la clase, false en caso contrario</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return a.claseQueToma != clase;
        }
        
        /// <summary>
        /// Verifica que el alumno tome la clase y no sea deudor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns>Retorna true si el alumno toma la clase y no es deudor, false en caso contrario</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return !(a != clase) && (a.estadoCuenta != EEstadoCuenta.Deudor);            
        }


        #endregion
    
    }
}
