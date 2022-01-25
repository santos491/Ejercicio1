using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peliculas2_API.Domain
{
    public record Films(string Titulo, string Director, string Genero, double Puntuacion, double Rating, double Año_Publicacion);
}
