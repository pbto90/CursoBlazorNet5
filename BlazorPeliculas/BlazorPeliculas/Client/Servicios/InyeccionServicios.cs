using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Servicios
{
    public class ServicioSingleton
    {  
        public int Valor { set; get; }
    }

    public class ServicioTransient
    {
        public int Valor { set; get; }
    }
}
