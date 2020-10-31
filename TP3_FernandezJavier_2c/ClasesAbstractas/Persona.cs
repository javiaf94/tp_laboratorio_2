using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero}

        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDNI(this.Nacionalidad, value);
            }
        }

        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDNI(this.Nacionalidad, value);
            }
        }


        #endregion

        #region Constructores
        
        /// <summary>
        /// Inicializa una nueva instancia de Persona, con sus parametros por defectos.
        /// </summary>
        public Persona()
        { 
        }

        /// <summary>
        /// Inicializa una nueva instancia de Persona. Validando Nombre y Apellido.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
       {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.nacionalidad = nacionalidad;
        }

        /// <summary>
        /// nicializa una nueva instancia de Persona. Validando Nombre y Apellido y DNI.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// nicializa una nueva instancia de Persona. Validando Nombre y Apellido y DNI.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        #endregion

        #region Metodos de validacion

        /// <summary>
        /// Valida que el DNI sea valido y se condiga con la nacionalidad
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>Retorna el DNI si es correcto. Arroja excepcion de DNI o Nacionalidad invalidos de no ser correctos</returns>
        private int ValidarDNI(ENacionalidad nacionalidad, int dato)
        {
            if(dato >= 1)
            {
                switch (this.Nacionalidad)
                {
                    case ENacionalidad.Argentino:
                        if (dato >= 1 && dato <= 89999999)
                            return dato;
                        else
                            throw new NacionalidadInvalidaException("El DNI no se condice con la nacionalidad.");                    

                    case ENacionalidad.Extranjero:
                        if (dato >= 90000000 && dato <= 99999999)
                            return dato;
                        else
                            throw new NacionalidadInvalidaException("El DNI no se condice con la nacionalidad");
                }
            }

            throw new DniInvalidoException("El DNI no es válido.");
        }            
            
        /// <summary>
        /// Valida que el DNI sea valido y se condiga con la nacionalidad
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>Retorna el DNI si es correcto. Arroja excepcion de DNI o Nacionalidad invalidos de no ser correctos</returns>
        private int ValidarDNI(ENacionalidad nacionalidad, string dato)
        {
            //valido que no tenga letras y cantidad de caracteres; el resultado lo paso a la otra validacion de DNI.           
            int aux;
            if (int.TryParse(dato, out aux) && dato.Length <= 8)
                return ValidarDNI(nacionalidad, aux);
            else
                return ValidarDNI(nacionalidad, aux);
                throw new DniInvalidoException("El Dni no es válido.");
        }

        /// <summary>
        /// Valida que el nombre o apellido sean validos.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Retorna el dato ingresado en caso de ser valido. Devuelve cadena de error de ser invalido</returns>
        private string ValidarNombreApellido(string dato)
        {
       //Dado que existen nombres con solo 1 caracter, valido que no posea numeros ni sea null o whitespace
            if (!string.IsNullOrWhiteSpace(dato) && !dato.Any(Char.IsDigit)) 
                return dato;
            else
                return "Nombre/apellido inválido";
        }

        #endregion
        
        /// <summary>
        /// Publica los datos de la persona.
        /// </summary>
        /// <returns>Retorna los datos de la persona</returns>
        public override string ToString()
        {
            StringBuilder strBuild = new StringBuilder();
            strBuild.AppendLine($"NOMBRE COMPLETO: {this.Apellido}, {this.Nombre}");
            strBuild.AppendLine($"NACIONALIDAD: {this.Nacionalidad}");
            strBuild.AppendLine($"DNI: {this.DNI.ToString("D8")}");

            return strBuild.ToString();
        }

    }
}
