using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaClases
{    
    public class Bajo : Instrumento
    {
        public enum ETipoBajo { Activo, Pasivo }

        private ETipoBajo tipo;

        #region Constructores
        public Bajo()
            : this("", "", "", 0, 0)
        {
        }

        public Bajo(string numSerie, string marca, string modelo, float precio, ETipoBajo tipo)
            : base(numSerie, marca, modelo, precio )
        {
            this.tipo = tipo;
        }
        #endregion


        public ETipoBajo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        /// <summary>
        /// Devuelve todos los datos del Bajo
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append(base.MostrarDatos());
            strBuild.Append($"Tipo: {this.tipo}  ");
            return strBuild.ToString();
        }

        /// <summary>
        /// publica los datos del Bajo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }       
    }
}
