using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using XSSExemple_Cliente.Models;

namespace XSSExemple_Cliente.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _client;
        public HomeController(ILogger<HomeController> logger)
        {
            _client = new HttpClient();
        }
        public IActionResult Index(string Message, string Type)
        {
            ViewBag.Message = Message;
            ViewBag.Type = Type;
            return View();
        }

        public async Task<IActionResult> AdicionarComentario(string comentario)
        {
            Comentario c = new Comentario
            {
                Texto = comentario
            };

            var data = new StringContent(
                   JsonConvert.SerializeObject(c, Formatting.Indented),
                    Encoding.UTF8,
                    "application/json");

            var response = await _client.PostAsync("http://localhost:63969/XSS/AddComment", data);

            var responsebody = await response.Content.ReadAsStringAsync();

            return RedirectToAction("Index", new { Message = responsebody, Type = "success"});
        }

        public async Task<IActionResult> Desprotegida()
        {
            var response = await _client.GetAsync("http://localhost:63969/XSS/GetComments");

            var responsebody = await response.Content.ReadAsStringAsync();

            var comments = JsonConvert.DeserializeObject<List<Comentario>>(responsebody);

            return View(comments);
        }
        public async Task<IActionResult> Protegida()
        {
            var response = await _client.GetAsync("http://localhost:63969/XSS/GetComments");

            var responsebody = await response.Content.ReadAsStringAsync();

            var comments = JsonConvert.DeserializeObject<List<Comentario>>(responsebody);

            return View(comments);
        }

        public async Task<IActionResult> Protegida2()
        {
            HttpContext.Response.Headers.Add("Content-Security-Policy", "script-src 'none'");

            var response = await _client.GetAsync("http://localhost:63969/XSS/GetComments");

            var responsebody = await response.Content.ReadAsStringAsync();

            var comments = JsonConvert.DeserializeObject<List<Comentario>>(responsebody);

            return View("Desprotegida", comments);
        }

        public IActionResult Login(string Username, string Password, string Message, string Type)
        {
            ViewBag.Username = Username;
            ViewBag.Password = Password;

            ViewBag.Message = Message;
            ViewBag.Type = Type;

            return View();

            //var url = "http://localhost:63969/ReceberDadosLogin";
        }
        
        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            //Simular login errado, assumir só existe a conta Username - Teste e Password - 12345
            if(Username != "teste" && Password != "12345")
            {
                return RedirectToAction("Login", new { Username = Username, Message = "Login falhou", Type = "danger" });
            }

            //Simular tempo login
            Thread.Sleep(1000);

            string jwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
            HttpContext.Response.Cookies.Append("Sessao", jwtToken, 
                new CookieOptions() { Expires = DateTime.Now.AddMinutes(1)});


            return RedirectToAction("Index",new { Message = "Login efetuado", Type = "success" });
        }

        public IActionResult PaginaPesquisa(string palavra)
        {
            ViewBag.palavra = palavra;
            return View();
        }

        [HttpPost]
        public IActionResult Pesquisa(string palavra)
        {
            //simlar uma query a base de dados
            Thread.Sleep(1000);

            return RedirectToAction("PaginaPesquisa", new { palavra = palavra});
        }

        public async Task<IActionResult> VerLogins()
        {
            var response = await _client.GetAsync("http://localhost:63969/XSS/RetornarLogins");

            var responsebody = await response.Content.ReadAsStringAsync();

            var logins = JsonConvert.DeserializeObject<List<Login>>(responsebody);

            return View(logins);
        }

        public async Task<IActionResult> VerTokens()
        {
            var response = await _client.GetAsync("http://localhost:63969/XSS/RetornarTokens");

            var responsebody = await response.Content.ReadAsStringAsync();

            var tokens = JsonConvert.DeserializeObject<List<Tokens>>(responsebody);

            return View(tokens);
        }

    }
}
