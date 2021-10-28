using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvento.API.Models;

namespace ProEvento.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(ILogger<EventoController> logger)
        {


        }

        [HttpGet]
        public List<Evento>Get()
        {
           return new List<Evento>{

              new Evento{
              EventoId = 1,
              Tema = "Encontro Turma ",
              Local = "Rincão",
              QtdPessoas = 20,
              Lote = "Primeiro",
              DataEvento = DateTime.Now.AddDays(2).ToString()
           },
            new Evento{
              EventoId = 2,
              Tema = "Encontro do Trio ",
              Local = "Araraquara",
              QtdPessoas = 80,
              Lote = "Segundo",
              DataEvento = DateTime.Now.AddDays(2).ToString()
           },
            new Evento{
              EventoId = 3,
              Tema = "Encontro das Patroas ",
              Local = "Rio de Janeiro",
              QtdPessoas = 300,
              Lote = "Terceiro",
              DataEvento = DateTime.Now.AddDays(2).ToString()
           },


           };
        }


        [HttpPost]

        public string Post()
        {
           return "Estamos no metodo Post ;-)";
        }

        [HttpDelete("{id}")]

        public string Delete(int id)
        {
           return $"Agora Delete com o id={id}";
        }
    }
}
