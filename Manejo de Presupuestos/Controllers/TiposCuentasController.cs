using Manejo_de_Presupuestos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Manejo_de_Presupuestos.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if(!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }
            return View();
        }
    }
}
