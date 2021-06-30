using System;
using Eplayers_AspnetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Eplayers_AspnetCore.Controllers
{
    [Route("Jogador")]
    public class JogadorController : Controller
    {
        Jogador jogador = new Jogador();
        Equipe eq = new Equipe();

        [Route("Listar")]
        public IActionResult Index()
        {   
            ViewBag.equipe = eq.ReadAll();
            ViewBag.jg = jogador.ReadAll();
            return View();
        }
        [Route("Cadastro")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador jog = new Jogador();

            jog.IdJogador = Int32.Parse( form["IdJogador"] );
            jog.Nome = form["Nome1"];
            jog.Email = form["Email"];
            jog.Senha = form["Senha"];

            jogador.Create(jog);
            ViewBag.jg =jogador.ReadAll();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("{id}")]
        public IActionResult delete(int id)
        {
            jogador.Delete(id);
            ViewBag.Equipes = jogador.ReadAll();

            return LocalRedirect("~/Jogador/Listar");
        }
    }
}