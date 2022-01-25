using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Peliculas2_API.Domain;

namespace Peliculas2_API.Infrastructure
{
    public class FilmsRepository
    {
        public List<Films> _Films;
        public FilmsRepository()
        {
            CreateData();
        }
        public async Task<int> Create(Films Films)
        {
            await Task.Delay(1000);
            return DateTime.Now.Millisecond;
        }

        public async Task<bool> Update(int id, Films newFilms)
        {
            await Task.Delay(1000);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            await Task.Delay(1000);
            return true;
        }

        public async Task<Films> GetFirst(int id)
        {
            await Task.Delay(1000);
            return _Films.ElementAt(--id);
        }

        public async Task<IEnumerable<Films>> GetAll()
        {
            await Task.Delay(1000);
            return _Films;
        }

        public async Task<IEnumerable<Films>> GetByFilter(Films filter)
        {
            var query = _Films.Select(x => x);

            if (!string.IsNullOrEmpty(filter.Titulo))
                query = query.Where(Films => Films.Titulo == filter.Titulo);

            if (!string.IsNullOrEmpty(filter.Director))
                query = query.Where(Films => Films.Director == filter.Director);

            if (!string.IsNullOrEmpty(filter.Genero))
                query = query.Where(Films => Films.Genero == filter.Genero);

            if (filter.Puntuacion > 0)
                query = query.Where(Films => Films.Puntuacion <= filter.Puntuacion);

            if (filter.Rating > 0)
                query = query.Where(Films => Films.Rating <= filter.Rating);

            if (filter.Año_Publicacion > 0)
                query = query.Where(Films => Films.Año_Publicacion <= filter.Año_Publicacion);

            await Task.Delay(1000);
            return query;
        }

        public void CreateData()
        {
            _Films = Enumerable.Range(0,2).Select(Films => new Films(
                Titulo: $"Horarios de Spider-Man: No Way Home_{Films}",
                Director: "Jon Watts",
                Genero: "Acción/Aventura",
                Puntuacion: 7.5,
                Rating: 4,
                Año_Publicacion : 2021


            )).ToList();
            _Films.Add(new Films(
                Titulo: "Venom: Carnage liberado",
                Director: "Andy Serkis",
                Genero: "Acción/Aventura",
                Puntuacion: 5.8,
                Rating: 4,
                Año_Publicacion: 2021
            ));

            var interviews = Enumerable.Range(0,1).Select(Films => new Films(
                Titulo: "Eternals",
                Director: "Chloé Zhao",
                Genero: "Acción/Aventura",
                Puntuacion: 3.8,
                Rating: 5,
                Año_Publicacion: 2021 
            ));

            _Films.AddRange(interviews);

            _Films.Add(new Films(
                Titulo: "Encanto",
                Director: "Byron Howard, Jared Bush",
                Genero: "Musical/Comedia",
                Puntuacion: 6.8,
                Rating: 6,
                Año_Publicacion: 2021
            ));

            var interview = Enumerable.Range(0, 1).Select(Films => new Films(
                 Titulo: "La casa bajo el agua",
                 Director: "Alexandre Bustillo, Julien Maury",
                 Genero: "Suspenso/Sobrenatural ",
                 Puntuacion: 6.8,
                 Rating: 7,
                 Año_Publicacion: 2021
             ));

            _Films.AddRange(interview);

            _Films.Add(new Films(
                Titulo: "Black Widow",
                Director: "Cate Shortland",
                Genero: "Acción/Aventura",
                Puntuacion: 7.8,
                Rating: 7,
                Año_Publicacion: 2021
            ));

            var Interview = Enumerable.Range(0, 1).Select(Films => new Films(
                Titulo: "Maligno",
                Director: "James Wan",
                Genero: "Terror/Suspenso",
                Puntuacion: 4.8,
                Rating: 4,
                Año_Publicacion: 2021
            ));

            _Films.AddRange(Interview);

            _Films.Add(new Films(
                Titulo: "Mortal Kombat",
                Director: "Simon McQuoid ",
                Genero: "Acción/Fantasia",
                Puntuacion: 3.8,
                Rating: 8,
                Año_Publicacion: 2021
            ));
        }
    }
}