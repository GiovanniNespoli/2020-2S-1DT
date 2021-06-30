using System.Collections.Generic;
using Eplayers_AspnetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eplayers_AspnetCore.Controllers
{
    public class LoginController : Controller 
    {
        [TempData]
        public string Mensagem { get; set; }
        
        
        Jogador jogadorModel = new Jogador();
        Equipe equipe = new Equipe();

        [Route("Login")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Logando")]
        public IActionResult Logar(IFormCollection form)
        {
             // Lemos todos os arquivos do CSV
        List<string> csv = jogadorModel.ReadAllLinesCSV("Database/Jogador.csv");

        // Verificamos se as informações passadas existe na lista de string
            var logado = 
            csv.Find(
            x => 
            x.Split(";")[3] == form["Email"] && 
            x.Split(";")[4] == form["Senha"]
            );


    // Redirecionamos o usuário logado caso encontrado
         if(logado != null)
        {
            HttpContext.Session.SetString("_UserName", logado.Split(";")[1]);
            return LocalRedirect("~/");
        }

        Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Login");
        }
        
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("_UserName");
            return LocalRedirect("~/");
        }
    }
}