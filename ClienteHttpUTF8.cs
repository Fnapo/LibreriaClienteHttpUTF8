using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClienteHttpUTF8
{
    public static class ClienteHttpUTF8
	{
		///
		/// <summary>
		/// Realiza una petición de lectura (GET) de un HttpClient <br/>
		/// a una cierta URL y devuelve una cadena codificada en UTF8.
		/// </summary>
		/// <param name="cliente">
		/// HttpClient que realiza la petición.
		/// </param>
		/// <param name="totalUrl">
		/// URL donde se realiza la petición.
		/// </param>
		/// <returns>
		/// Una Task&lt;string&gt; codificada en UTF8 con toda la información.
		/// </returns>
		/// 
		static public async Task<string> PrepararGetUTF8(HttpClient cliente, string totalUrl)
        {
            var respuesta = await cliente.GetByteArrayAsync(totalUrl);

            return Encoding.UTF8.GetString(respuesta, 0, respuesta.Length);
        }
    }
}
