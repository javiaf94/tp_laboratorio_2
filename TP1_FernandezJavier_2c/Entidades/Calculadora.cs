using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
       /// <summary>
       /// Valida que un caracter sea un operador válido.
       /// </summary>
       /// <param name="operador">ca</param>
       /// <returns>Siendo el parámetro válido retorna el mismo. De lo contrario retorna el operador '+'</returns>
        private static string ValidarOperador(char operador)
        {
            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
                return "+";
            else
                return operador.ToString();
        }
        

        /// <summary>
        /// Realiza una operación aritmética entre dos números.
        /// </summary>
        /// <param name="num1">Primer operando</param>
        /// <param name="num2">Segundo operando</param>
        /// <param name="operador">Operando matemático (+,-,*,/)</param>
        /// <returns>Retorna el resultado de la operacion aritmética entre ambos operandos</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0; 

            //hago esta validacion fuera del ValidarOperador. ya que no encontre forma de que no crashee si le paso un string vacio. 
            if (string.IsNullOrEmpty(operador)) 
            {                                  
                operador = "+";
            }
            
            operador = ValidarOperador(operador[0]);
            switch (operador[0])
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '/':
                    resultado = num1 / num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;
            }   //ya que al ValidarOperador siempre voy a retornar un + por defecto no pongo la clausula default en el switch.

            return resultado;
        }
        

    }

}
    

