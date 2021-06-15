using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Helpers
{
    public static class Helpers
    {
        public static string ConvierteEnMayusculas(string texto) 
        {
            return texto.ToUpper();
        }
    }
}
