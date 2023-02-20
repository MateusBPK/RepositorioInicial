using curso.web.mvc.Models.Cursos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace curso.web.mvc.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(CadastrarCursoViewModel cadastrarCursoViewModel)
        {
            return View();
        }

        public IActionResult Listar()
        {
            var cursos = new List<ListarcursoViewModelOutput>();
            cursos.Add(new ListarcursoViewModelOutput()
            {
                Nome = "Curso A",
                Descricao = "Descricao Curso A",
                Login =  "Mateus V. M."
            });
            cursos.Add(new ListarcursoViewModelOutput()
            {
                Nome = "Curso B",
                Descricao = "Descricao Curso B",
                Login = "Mateus V."
            });
            return View(cursos);
        }
    }
}
