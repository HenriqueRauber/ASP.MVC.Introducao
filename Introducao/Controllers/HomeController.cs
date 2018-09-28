using Introducao.Models;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Hugo Vasconcelos",
                Tipo = "Administrador"
            };

            //ViewData["PessoaId"] = pessoa.PessoaId;
            //ViewData["Nome"] = pessoa.Nome;
            //ViewData["Tipo"] = pessoa.Tipo;

            //ViewBag.Id = pessoa.PessoaId;
            //ViewBag.nome = pessoa.Nome;
            //ViewBag.tipo = pessoa.Tipo; 



            return View(pessoa);
        }
        public ActionResult Contatos()
        {
            return View();
        }

        //1ª forma
        //[HttpPost]
        //public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        //{
        //    ViewData["PessoaId"] = PessoaId;
        //    ViewData["Nome"] = Nome;
        //    ViewData["Tipo"] = Tipo;

        //    return View();
        //}

        //2ª forma
        //[HttpPost]
        //public ActionResult Lista(FormCollection form)
        //{
        //    ViewData["PessoaId"] = form["PessoaId"];
        //    ViewData["Nome"] = form["Nome"];
        //    ViewData["Tipo"] = form["Tipo"];

        //    return View();
        //}

        ////3ª forma
        //[HttpPost]
        //public ActionResult Lista(Pessoa pessoa)
        //{
        //    ViewData["PessoaId"] = pessoa.PessoaId;
        //    ViewData["Nome"] = pessoa.Nome;
        //    ViewData["Tipo"] = pessoa.Tipo;

        //    return View();
        //}

             
        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }
    }
}