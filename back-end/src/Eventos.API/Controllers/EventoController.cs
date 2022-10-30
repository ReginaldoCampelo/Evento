using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                    EventoId = 1,
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                    Tema = "Angular e .NET Core",
                    QtdPessoas = 200,
                    Lote = "1º Lote",
                    ImagemUrl = "foto.png"
                },
                new Evento() {
                    EventoId = 2,
                    Local = "Rio de Janeiro",
                    DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                    Tema = "Angular e .NET Core",
                    QtdPessoas = 200,
                    Lote = "1º Lote",
                    ImagemUrl = "foto.png"
                },
                new Evento() {
                    EventoId = 3,
                    Local = "Belo Horizonte",
                    DataEvento = DateTime.Now.ToString("dd/MM/yyyy"),
                    Tema = "Angular e .NET Core",
                    QtdPessoas = 200,
                    Lote = "1º Lote",
                    ImagemUrl = "foto.png"
                }
            };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Exemplo de Put";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo de Delete";
        }
    }
}
