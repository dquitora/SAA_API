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
    public class EditorialesController : ControllerBase
    {
        private readonly AppDBContext context;
        Entities.Editoriales Editorial1;

        public EditorialesController(AppDBContext context)
        {
            this.context = context;
            Editorial1 = new Entities.Editoriales();
        }

        [HttpGet]
        public IEnumerable<Editoriales> Get()
        {
            return context.Editoriales.ToList();
        }

        [HttpGet("{id}")]
        public Editoriales Get(int id)
        {
            var editorial = context.Editoriales.FirstOrDefault(c => c.id_editorial == id);
            return editorial;
        }

        [HttpGet]
        [Route("GETEDITORIALES")]
        public async Task<String> GETAUTORES()
        {
            String Editorial2 = Editorial1.GETEDITORIALES(1);

            if (Editorial2 == null)
            {
                return "";
            }

            return Editorial2;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Editoriales editorial)
        {
            try
            {
                context.Editoriales.Add(editorial);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Editoriales editorial)
        {
            if (editorial.id_editorial == id)
            {
                context.Entry(editorial).State = EntityState.Modified;
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
            var editorial = context.Editoriales.FirstOrDefault(c => c.id_editorial == id);
            if (editorial != null)
            {
                context.Editoriales.Remove(editorial);
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
