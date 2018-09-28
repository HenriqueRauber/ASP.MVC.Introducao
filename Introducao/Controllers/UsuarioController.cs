using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();

            return View();
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {

            ////////Exemplo.. adicionado verificação no controller..
            ////////Mostrar mensagem de erro no campo
            //////if (string.IsNullOrEmpty(usuario.Nome))
            //////{
            //////    ModelState.AddModelError("Nome", "O campo Nome é obrigatório!");
            //////}  
            ////////"" Mostrar a mensagem no validador da tela..
            //////if (usuario.Senha != usuario.ConfirmarSenha)
            //////{
            //////    ModelState.AddModelError("", "As senhas são diferentes!");
            //////}

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public JsonResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugo",
                "Freitas",
                "Rauber"
            };
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}