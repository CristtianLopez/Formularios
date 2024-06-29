using Formularios.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Diagnostics;

namespace Formularios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult EditorFor() 
        { 
            return View(); 
        }

        public IActionResult DisplayNameFor() 
        {
            var usuario = new UsuarioDisplay
            {
                Id = 1,
                Nombre = "Juan Pérez",
                Email = "juan.perez@example.com",
                Password = "password",
                Pais = "Argentina",
                FechaNacimiento = new DateTime(1990, 5, 23),
                Comentarios = "Interesado en recibir información sobre productos nuevos.",
                AceptoTerminos = true
            };

            return View(usuario);
        }

        public IActionResult LabelForEditorFor()
        {
            return View();
        }
        public IActionResult LabelTagHelperInputTagHelper()
        {
            return View();
        }
        public IActionResult TagHelper()
        {
            return View("FormularioTagHelper");
        }

        public IActionResult HtmlHelper()
        {
            // Get the list of countries (from a database, API, etc.)
            List<SelectListItem> paises = new List<SelectListItem>();
            paises.Add(new SelectListItem { Text = "Argentina", Value = "Argentina" });
            paises.Add(new SelectListItem { Text = "Chile", Value = "Chile" });
            paises.Add(new SelectListItem { Text = "Uruguay", Value = "Uruguay" });

            // Pass the list of countries to the view
            ViewBag.Paises = paises;
            return View("FormularioHtmlHelper");
        }

        public IActionResult HtmlHelperValidado()
        {
            // Get the list of countries (from a database, API, etc.)
            List<SelectListItem> paises = new List<SelectListItem>();
            paises.Add(new SelectListItem { Text = "Argentina", Value = "Argentina" });
            paises.Add(new SelectListItem { Text = "Chile", Value = "Chile" });
            paises.Add(new SelectListItem { Text = "Uruguay", Value = "Uruguay" });

            // Pass the list of countries to the view
            ViewBag.Paises = paises;
            return View();
        }

        [HttpPost]
        public string Create()
        {
            if (ModelState.IsValid)
            {
                return "Modelo valido";
            }
            else {
                return "Modelo invalido";
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
