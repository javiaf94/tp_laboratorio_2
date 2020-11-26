using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaClases
{
    
    public class Guitarra : Instrumento
    {
        public enum ETipoGuitarra { Electrica, Acustica}
        
        private ETipoGuitarra tipo;

        #region Constructores
        public Guitarra()
            : this("", "", "", 0, 0)
        {
        }

        public Guitarra(string numSerie, string marca, string modelo, float precio, ETipoGuitarra tipo)
            : base(numSerie, marca, modelo, precio)
        {
            this.tipo = tipo;
        }
        #endregion


        public ETipoGuitarra Tipo
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
        /// Devuelve todos los datos de la guitarra.
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
        /// Publica todos los datos de la guitarra.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
