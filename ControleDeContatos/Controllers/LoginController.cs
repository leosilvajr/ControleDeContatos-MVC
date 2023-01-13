using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ControleDeContatos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (loginModel.Login == "admin" && loginModel.Senha == "admin")
                    {
                    return RedirectToAction("Index", "Home");

                    }
                    TempData["MensagemErro"] = "Usuario ou Senha invalido.";
                }

                return View("Index");

            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar o seu login. Tente novamente, detalhes do erro: {e.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
