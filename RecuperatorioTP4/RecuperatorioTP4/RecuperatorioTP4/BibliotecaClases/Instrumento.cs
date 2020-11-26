using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaClases
{
    [XmlInclude(typeof(Guitarra))]
    [XmlInclude(typeof(Bajo))]
    public abstract class Instrumento
    {         
        
        private string numSerie;
        private string marca;
        private string modelo;
        private float precio;        

        #region Constructores
        public Instrumento()
        {
        }

        public Instrumento(string numSerie, string marca, string modelo, float precio)
        {
            this.NumSerie = numSerie;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;            
        }
        #endregion


        #region Propiedades
        public string Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                    this.marca = value;
            }
        }

        public string NumSerie
        {
            get
            {
                return numSerie; 
            }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    this.numSerie = value; 
            }
        }

        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }

        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if(value > 0)
                    this.precio = value;
            }
        }


        #endregion
        
        public static bool operator ==(Instrumento i1, Instrumento i2)
        {
            return i1.numSerie == i2.numSerie && i1.marca == i2.marca;
        }

        public static bool operator !=(Instrumento i1, Instrumento i2)
        {
            return !(i1 == i2);
        }
        

        /// <summary>
        /// Devuelve todos los datos del Instrumento, formateando el precio correctamente.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append($"Marca: {this.marca}  ");
            strBuild.Append($"Modelo: {this.modelo}  ");
            strBuild.Append($"Numero de serie: {this.numSerie}  ");
            strBuild.Append($"Precio: {this.precio.FormatearPrecio()}  ");
            return strBuild.ToString();
        }
    }
}
