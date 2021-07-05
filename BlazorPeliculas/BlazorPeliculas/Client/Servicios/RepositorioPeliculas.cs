using BlazorPeliculas.Client.Servicios.Interfaces;
using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Servicios
{
    public class RepositorioPeliculas : IRepositorioPeliculas
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
             {
                new Pelicula()
                {
                    Titulo = "Halloween 2018",
                    Poster = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQQw48FNY77_pgjopclYcLvBk7krJdPXjuFiyaTYwG1r-g-rUYU",
                    FechaLanzamiento = new DateTime(2018, 10, 31)
                },
                new Pelicula()
                {
                    Titulo = "Halloween Kills",
                    Poster = "https://www.hellofriki.com/wp-content/uploads/2021/06/halloween-kills-poster-2-scaled.jpg",
                    FechaLanzamiento = new DateTime(2021, 10, 31)
                },
                new Pelicula()
                {
                    Titulo = "Halloween Ends",
                    Poster = "https://pics.filmaffinity.com/Halloween_Ends-980234881-large.jpg",
                    FechaLanzamiento = new DateTime(2022, 10, 31)
                }
             };
        }
    }
}
