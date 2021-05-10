using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region "Constructores"

        /// <summary>
        /// Constructor parametrizado. 
        /// </summary>
        /// <param name="marca">Marca de la Suv</param>
        /// <param name="chasis">Chasis de la Suv</param>
        /// <param name="color">Color de la Suv</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {

        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Propiedad que retorna el tamaño de la Suv(Por defecto Grande)
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        /// <summary>
        /// Muestra los datos de una Suv
        /// </summary>
        /// <returns>Retorna los datos en formato de cadena</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Suv");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO  : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("\r\n---------------------");

            return sb.ToString();
        }

        #endregion
    }
}

