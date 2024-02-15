using Manejo_de_Presupuestos.Models;
using Manejo_de_Presupuestos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manejo_de_Presupuestos.Controllers
{
    public class TiposCuentasController : Controller
    {
        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas)
        {
            this.repositorioTiposCuentas = repositorioTiposCuentas;
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if ( !ModelState.IsValid )
            {
                return View( tipoCuenta ); // Devuelve la vista con el modelo válido y los errores de validación.
            }

            tipoCuenta.UsuarioId = 1;
            repositorioTiposCuentas.Crear( tipoCuenta );

            return RedirectToAction( "Index", "Home" ); // Redirige a alguna otra página después de la creación exitosa.
        }

    }
}
