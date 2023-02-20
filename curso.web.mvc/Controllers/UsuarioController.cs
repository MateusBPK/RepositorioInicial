using curso.web.mvc.Models.Usuario;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace curso.web.mvc.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(RegistrarUsuarioViewModelInput registrarUsuarioViewModelInput)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:5001/");
            var registrarUsuarioViewModelInputJson = JsonConvert.SerializeObject(registrarUsuarioViewModelInput);

            var httpContent = new StringContent(registrarUsuarioViewModelInputJson);

            var httpPost = httpClient.PostAsync("/api/v1/usuario/registrar", httpContent).GetAwaiter().GetResult();

            if (httpPost.StatusCode ==System.Net.HttpStatusCode.Created)
            {
                ModelState.AddModelError("","Os dados foram cadastrados com sucesso");
            }
            else
            {
                ModelState.AddModelError("", "Erro ao cadastrar");
            }
            
            return View();
        }

        public IActionResult Logar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return View();
        }


    }
}
