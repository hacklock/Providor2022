using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EventoController> _logger;
        private readonly DataContext _context;  // ctrl + . inicialize from field parameter tive q add underscore

        public EventoController(DataContext context)
        {
            _context = context;

        }


        // public IEnumerable<Evento> _evento = new Evento[] {
        //        new Evento() {
        //         EventoId = 1,
        //         Tema = "Angular 11 e .NET 5",
        //         Local = "Belo Horizonte",
        //         Lote = "1º Lote",
        //         QtdPessoas = 250,
        //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //         ImageURL = "foto.png"
        //         },


        //         new Evento() {
        //         EventoId = 2,
        //         Tema = "Angular e suas Novidades",
        //         Local = "São Paulo",
        //         Lote = "2º Lote",
        //         QtdPessoas = 350,
        //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //         ImageURL = "foto1.png"
        //         }

        //     };

        [HttpGet]

        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }


        [HttpGet("{id}")]

        //public IEnumerable<Evento> GetById(int id)
        public Evento GetById(int id)
        {
            //return _context.Eventos.Where(evento => evento.EventoId == id); // onde dado um evento
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id); // Sem colchetes e retorna um elemento somente
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }


    }
}
