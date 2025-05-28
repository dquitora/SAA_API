using System;
using System.Collections.Generic;
using System.Linq;
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
    public class LibrosController : ControllerBase
    {
        private readonly AppDBContext context;

        public LibrosController(AppDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Libros> Get()
        {
            return context.Libros.ToList();
        }

        [HttpGet("{id}")]
        public Libros Get(int id)
        {
            var libro = context.Libros.FirstOrDefault(c => c.id_libro == id);
            return libro;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Libros libro)
        {
            try
            {
                context.Libros.Add(libro);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Libros libro)
        {
            if (libro.id_libro == id)
            {
                context.Entry(libro).State = EntityState.Modified;
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
            var libro = context.Libros.FirstOrDefault(c => c.id_libro == id);
            if (libro != null)
            {
                context.Libros.Remove(libro);
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
