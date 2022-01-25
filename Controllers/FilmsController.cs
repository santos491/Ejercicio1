using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Peliculas2_API.Infrastructure;
using Peliculas2_API.Domain;

namespace Peliculas2_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var repository = new FilmsRepository();
            var Films = await repository.GetAll();
            return Ok(Films);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var repository = new FilmsRepository();
            var Films = await repository.GetFirst(id);
            return Ok(Films);
        }

        [HttpGet]
        [Route("Ruta1/{Genero}")]
        public async Task<IActionResult> GetByGenero(string Genero)
        {
            var film = new Films(Titulo: "", Director: "", Genero:"", Puntuacion: 0, Rating: 0, Año_Publicacion: 0);
            var repository = new FilmsRepository();
            var films = await repository.GetByFilter(film);
            return Ok(films);
        }

        [HttpGet]
        [Route("Ruta2/{Titulo}")]
        public async Task<IActionResult> GetByTitulo(string Titulo)
        {
            var film = new Films(Titulo: "", Director: "", Genero: "", Puntuacion: 0, Rating: 0, Año_Publicacion: 0);
            var repository = new FilmsRepository();
            var films = await repository.GetByFilter(film);
            return Ok(films);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Films Films)
        {
            var repository = new FilmsRepository();
            var id = await repository.Create(Films);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Films Films)
        {
            var repository = new FilmsRepository();
            var isChanged = await repository.Update(id, Films);
            return Ok(isChanged);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var repository = new FilmsRepository();
            var isDeleted = await repository.Delete(id);
            return Ok(isDeleted);
        }
    }
}
