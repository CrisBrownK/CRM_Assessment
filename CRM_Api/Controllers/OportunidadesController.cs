﻿using Dominio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRM_Api.Controllers
{
    [Route("api/oportunidad")]
    [ApiController]
    public class OportunidadesController : ControllerBase
    {
        List<Oportunidad> oportunidades = new List<Oportunidad>()
        {
            new Oportunidad()
            {
            },
            new Oportunidad()
            {
            }
        };

        // GET: api/<OportunidadesController>
        [HttpGet]
        public IActionResult Get()
        {
            //Mostrar lista de oportunidades
            //return new string[] { "value1", "value2" };

            return Ok(oportunidades);
        }

        // GET api/<OportunidadesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //Mostrar detalles de oportunidad
            return "value";
        }

        // POST api/<OportunidadesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //Crear oportunidad
        }

        // PUT api/<OportunidadesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //Cambiar estado a contratado
        }

        
    }
}
