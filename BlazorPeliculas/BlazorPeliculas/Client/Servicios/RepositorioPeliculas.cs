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
                    FechaLanzamiento = new DateTime(2018, 10, 31)
                },
                new Pelicula()
                {
                    Titulo = "Halloween Kills",
                    FechaLanzamiento = new DateTime(2021, 10, 31)
                },
                new Pelicula()
                {
                    Titulo = "Halloween Ends",
                    FechaLanzamiento = new DateTime(2022, 10, 31)
                }
             };
        }
    }
}
