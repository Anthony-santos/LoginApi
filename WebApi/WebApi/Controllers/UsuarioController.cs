using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class PagamentoControler : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Usuario>> Post([FromServices] DataContext context, [FromBody] Usuario model)
        {
            if(ModelState.IsValid)
            {
                context.Usuarios.Add(model);
                await context.SaveChangesAsync();
                return Ok("Usuario Cadastrado");
            }
            else
            {
                return StatusCode(412, ModelState);
            }
        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Usuario>> GetById([FromServices] DataContext context, int id)
        {
            var usuario = await context.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return Ok(usuario);
        }
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<Usuario>> Login([FromServices] DataContext context, string email, string senha)
        {
            var usuario = await context.Usuarios
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email && x.senha == senha);
            return Ok(usuario);
        }
    }
}