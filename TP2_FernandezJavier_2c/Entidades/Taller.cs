﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }
       


        #region "Constructores"
        /// <summary>
        /// instancia la clase e inicializa la lista de vehiculos.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// instancia la clase asignando el espacio disponible en el taller.
        /// </summary>
        /// <param name="espacioDisponible"></param>
        public Taller(int espacioDisponible)
            : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tenemos {taller.vehiculos.Count} lugares ocupados de un total de {taller.espacioDisponible} disponibles.\n");
            sb.AppendLine($"Listando {tipo.ToString()}:\n"); //agregue esta linea solo para que sea un poco mas legible lo que se muestra.
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if(v is Ciclomotor)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.SUV:
                        if(v is Suv)
                            sb.AppendLine(v.Mostrar());
                        break;
                    case ETipo.Todos:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }
            return sb.ToString();
        }

        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if (taller.vehiculos.Count() < taller.espacioDisponible)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                        return taller;
                }
                taller.vehiculos.Add(vehiculo);
            }
            return taller;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            for(int i=0; i<taller.vehiculos.Count(); i++)
            {
                if(vehiculo == taller.vehiculos[i])
                {
                    taller.vehiculos.RemoveAt(i);
                    break;
                }
            }
            return taller;
        }
    }
        #endregion
}
                    

