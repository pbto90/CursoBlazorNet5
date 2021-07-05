using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades
{
    public class Pelicula
    {
        public string Titulo { set; get; }
        public DateTime FechaLanzamiento { set; get; }
        public string Poster { set; get; }

        public string TituloCortado 
        {
            get 
            {
                if (string.IsNullOrEmpty(Titulo)) 
                {
                    return null;
                }

                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }

                else 
                {
                    return Titulo;
                }
            }
        }
    }
}
