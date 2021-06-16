using BlazorPeliculas.Shared.Entidades;
using System.Collections.Generic;


namespace BlazorPeliculas.Client.Servicios.Interfaces
{
    public interface IRepositorioPeliculas
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
