using System;
using Eplayers_AspnetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Eplayers_AspnetCore.Controllers
{
    public class JogadorController : Controller
    {
        Jogador jogador = new Jogador();

        public IActionResult Index()
        {
            ViewBag.jg = jogador.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador jog = new Jogador();

            jog.IdJogador = Int32.Parse( form["IdJogador"] );
            jog.Nome = form["Nome1"];
            jog.Email = form["Email"];
            jog.Senha = form["Senha"];

            jogador.Create(jog);
            ViewBag.jg =jogador.ReadAll();

            return LocalRedirect("~/Jogador");
        }
    }
}