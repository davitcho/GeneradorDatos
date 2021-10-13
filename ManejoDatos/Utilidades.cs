using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoDatos
{
    public static class Utilidades
    {

        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public static bool IsDate(this string s)
        {
            DateTime dt;
            return DateTime.TryParse(s, out dt);
        }
        public static string DateToString(DateTime Fecha)
        {
            return Fecha.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
