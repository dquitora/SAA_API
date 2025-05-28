using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustAPI.Contexts;
using CustAPI.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustAPI.Controllers
{
    [EnableCors("MyPolicy")]
    [ApiController]
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        private readonly AppDBContext context;
        Entities.Autores Autor1;

        public AutoresController(AppDBContext context)
        {
            this.context = context;
            Autor1 = new Entities.Autores();
        }

         [HttpGet]
        public IEnumerable<Autores> Get()
        {
            return context.Autores.ToList();
        }

        [HttpGet("{id}")]
        public Autores Get(int id)
        {
            var autor = context.Autores.FirstOrDefault(c => c.id_autor == id);
            return autor;
        }

        [HttpGet]
        [Route("GETAUTORES")]
        public async Task<String> GETAUTORES()
        {
            String Autor2 = Autor1.GETAUTORES(1);

            if (Autor2 == null)
            {
                return "";
            }

            return Autor2;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Autores autor)
        {
            try
            {
                context.Autores.Add(autor);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Autores autor)
        {
            if (autor.id_autor == id)
            {
                context.Entry(autor).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var autor = context.Autores.FirstOrDefault(c => c.id_autor == id);
            if (autor != null)
            {
                context.Autores.Remove(autor);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
