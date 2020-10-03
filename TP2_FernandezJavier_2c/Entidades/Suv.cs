using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Instancia un objeto de la clase con los parametros seleccionados.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Publica los datos de la instancia de SUV
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar() //Dejé el sealed que venía por defecto ya que actualmente es una clase sin herencia asique es indistinto.
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}.");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
