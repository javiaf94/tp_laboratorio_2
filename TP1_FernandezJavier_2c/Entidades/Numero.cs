using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;


        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        #region constructores
        /// <summary>
        /// Instancia un nuevo Numero, con su valor en 0.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Instancia un nuevo Numero, con el valor pasado por parametro
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Instancia un nuevo Numero, validando la cadena parametro. De ser un valor inválido asigna 0.
        /// </summary>
        /// <param name="strNumero"></param>
        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }
        #endregion


        #region sobrecarga_operadores

        /// <summary>
        /// Suma los atributos numero de dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el valor de la suma en formato double</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Resta los atributos numero de dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el valor de la resta en formato double</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Multiplica los atributos numero de dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el valor de la multiplicacion en formato double</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        ///  Divide los atributos numero de dos objetos Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Retorna el valor de la division en formato double. Si n2 es 0, etorna el valor minimo que puede tomar un double.</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
                return double.MinValue;
            else
                return n1.numero / n2.numero;
        }
        #endregion


        /// <summary>
        /// Valida que el parametro sea un numero valido
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>Retorna en formato double la cadena recibida, de no recibir un numero retorna 0</returns>
        private double ValidarNumero(string strNumero)
        {
            double numeroParseado;
            double.TryParse(strNumero, out numeroParseado);

            return numeroParseado;
        }

        /// <summary>
        /// Valida que la cadena pasada por parametro corresponda a un numero binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna true en caso de ser binario, false si no es un numero binario</returns>
        private static bool EsBinario(string binario)
        {
            bool resultado = true;

            if (string.IsNullOrWhiteSpace(binario))
                resultado = false;

            else
                foreach (char c in binario)
                    if (c != '0' && c != '1')
                    {
                        resultado = false;
                        break;
                    }
            return resultado;
        }
                        


        /// <summary>
        /// Convierte, de ser posible, un numero Binario en decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Retorna en formato string el numero decimal. De recibir un valor invalido retorna "Valor inválido".</returns>
        public static string BinarioDecimal(string binario)
        {
            if (!Numero.EsBinario(binario))
            {
                return "Valor inválido";
            }
            else
            {
                int resultado = 0;
                int aux = binario.Length - 1;     //uso aux como indice para recorrer el string desde el final

                for (int i = 0; i < binario.Length; i++) //uso i como potencia
                {
                    if (binario[aux] == '1')
                    {
                        resultado += (int)Math.Pow(2, i);
                    }
                    aux--;
                }

                return resultado.ToString();
            }
        }

        /// <summary>
        /// Convierte, de ser posible, un numero decimal en binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna en formato string el numero binario. De recibir un valor invalido retorna "Valor inválido".</returns>
        public static string DecimalBinario(double numero)
        {
            int contador = 0;
            string resultado = "";

            int numeroInt = Math.Abs( (int) numero);
            
            if(numeroInt == 0) //valido si se el numero que se ingreso es 0
            {
                resultado = "0";
                return resultado; //si es 0 ya retorno el resultado para evitarme invertir el string resultado
            }
            
            while (numeroInt > 0)
            {
                resultado = resultado.Insert(contador, (numeroInt % 2).ToString()); //guardo cada bit subsecuentemente en el string
                numeroInt = (numeroInt / 2);
                contador++;
            }

            char[] reversor = resultado.ToCharArray(); //reordeno el string de atrás para adelante
            Array.Reverse(reversor);
            resultado = new string(reversor);

            return resultado;
        }


        /// <summary>
        /// Convierte de ser posible un numero decimal en binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna en formato string el numero binario. De recibir un valor invalido retorna "Valor inválido"</returns> 
        public static string DecimalBinario(string numero)
        {
            double aux;
            
            if (!double.TryParse(numero, out aux))
                return "Valor inválido";
            
            else
                return DecimalBinario(aux);
        }













    }
}
