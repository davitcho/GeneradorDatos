using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ManejoDatos
{
	/// <summary>
	/// Clase para generar tipos de datos
	/// </summary>
    public static class GeneradorTipoDato
    {
		private static readonly Random _random = new Random();
		/// <summary>
		/// Genera número entero aleatorio
		/// </summary>
		/// <returns>int</returns>
		public static int GenerarNumero()
		{
			return _random.Next();
		}
		/// <summary>
		/// Genera número entero aleatorio hasta un valor máximo
		/// </summary>
		/// <param name="maxValue">Número máximo para semilla</param>
		/// <returns></returns>
		public static int GenerarNumero(int maxValue)
		{
			return _random.Next(maxValue);
		}
		/// <summary>
		/// Genera número entero aleatorio entre dos valores
		/// </summary>
		/// <param name="minValue">Número minimo para semilla (entero)</param>
		/// <param name="maxValue">Número máximo para semilla (entero)</param>
		/// <returns>valor entero aleatorio entre valore ingresados</returns>
		public static int GenerarNumero(int minValue, int maxValue)
		{
			return _random.Next(minValue, maxValue);
		}
		/// <summary>
		/// genera valor booleano aleatorio 
		/// </summary>
		/// <returns>bool true/false</returns>
		public static bool GenerarBoolean()
        {
            return GenerarNumero(2) == 1;
        }
		public static string GenerarStringNumero()
		{
			return GenerarNumero().ToString();
		}
		public static string GenerarBoolString()
        {
			return GenerarBoolean().ToString();
        }
		public static string GenerarStringNumero(int length)
		{
			return GenerarSelectFrom(length, "0123456789");
		}

		public static string GenerarSting(int length)
		{
			return GenerarSelectFrom(length, "abcdefghijkmnopqrstuvwxyz");
		}

		public static string GenerarAlfanumerico(int length)
		{
			return GenerarSelectFrom(length, "0123456789abcdefghijkmnopqrstuvwxyz");
		}

		public static string GenerarAlfanumerico()
		{
			return GenerarSelectFrom(255, "0123456789abcdefghijkmnopqrstuvwxyz");
		}

		public static string GenerarSelectFrom(int numElements, string characters)
		{
			var returned = new StringBuilder();
			var length = characters.Length;
			while (numElements > 0)
			{
				returned.Append(characters[GenerarNumero(length)]);
				numElements--;
			}

			return returned.ToString();
		}

		public static string GenerarRandomize(string pattern)
		{
			return Regex.Replace(pattern, "[#\\?]",
				m => (m.ToString() == "#" ? GenerarStringNumero(1) : GenerarSting(1))
				);
		}

	}
}
