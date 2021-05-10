using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region "Enumerados"
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas
        }
        #endregion

        #region "Atributos"

        private ETipo tipo;

        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor parametrizado. Asigna el tipo(Por defecto, será CuatroPuertas)
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor parametrizado. Sobrecargado
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : this(marca, chasis, color)
        {
            this.tipo = tipo;

        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        ///Propiedad que retorna el tamaño del Sedan(Por defecto Mediano)
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

      

       /// <summary>
       /// Muestra los datos de un Sedan
       /// </summary>
       /// <returns>Retornara una cadena con los datos</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Sedan");
            sb.AppendLine(base.Mostrar());
            sb.Append("TAMAÑO : " + this.Tamanio.ToString());
            sb.Append(" TIPO : " + this.tipo.ToString());
            sb.AppendLine(" ");
            sb.AppendLine("\r\n---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
