using Microsoft.AspNetCore.Mvc;
using WebApplication1Test.Models;

namespace WebApplication1Test.Controllers
{
    public class HolamundoController : Controller
    {
        // Acción Index que retorna una vista
        public IActionResult Index()
        {
            ViewBag.Message = "Bienvenido a la página de inicio";
            ViewData["Nombre"] = "Andres";
            TempData["Notice"] = "Operación completada";
            List<string> autos = new List<String>() { "Mercedes", "BMW", "Audi", "Volvo" };
            ViewData["Autos"] = autos;
            ViewBag.Autos = autos;
            return View();
        }

        // Otra acción que retorna un mensaje de texto
        public IActionResult About()
        {
            return Content("Esta es la acción About.");
        }

        public IActionResult Welcome()
        {
            return View("Welcome");
        }
            
        public IActionResult SaludoconNombre(String nombre)
        {
            //http://localhost:5294/Holamundo/SaludoconNombre?nombre=Andres
            return Content("Hola " + nombre);
        }

        // Acción que retorna un JSON
        public IActionResult GetJsonData()
        {
            var data = new { Name = "John", Age = 30 };
            return Json(data);
        }

        // Acción que retorna una vista parcial
        public IActionResult Partial()
        {
            return PartialView("_PartialViewName");
        }

        // Acción que retorna una redirección
        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index");
        }

        // GET: /HelloWorld/Welcome/ 

        public string WelcomeHola()
        {
            return "This is the Welcome action method...";
        }

        public IActionResult Clientes()
        {
            List<Cliente> clientes = new List<Cliente>() {
            new Cliente() {
                id_cliente = 1,
                Nombre ="Andres",
                Edad = 29,
                Correo = "andresco@hotmail.com"
            },
            new Cliente()
            {
                id_cliente=2,
                Nombre = "Carlos",
                Edad = 29,
                Correo = "carlos@outlook.com"
            },
            new Cliente()
            {
                id_cliente=2,
                Nombre = "Fausto",
                Edad = 38,
                Correo = "fausto@utlook.com"
            }
            };
            ViewData["Clientes"] = clientes; //Para pasar información a la vista
            ViewBag.Message = "Bienvenido a la página de inicio";
            ViewData["Nombre"] = "Andres";
            TempData["Notice"] = "Operación completada";
            ViewBag.ClientesEnviar = clientes;
            return View("Cliente");
        }
    }
}
