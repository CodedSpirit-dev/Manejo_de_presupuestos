using Manejo_de_Presupuestos.Models;
using Manejo_de_Presupuestos.Services;
using Microsoft.AspNetCore.Mvc;

namespace Manejo_de_Presupuestos.Controllers
{
    public class TiposCuentasController : Controller
    {
        private IRepositoryTiposCuentas _repositoryTiposCuentas;

        public TiposCuentasController(IRepositoryTiposCuentas repositoryTiposCuentas)
        {
            _repositoryTiposCuentas = repositoryTiposCuentas;
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
                return View( tipoCuenta );
            }

            tipoCuenta.UsuarioId = 2;

            _repositoryTiposCuentas.Crear( tipoCuenta );

            return View();
        }
    }
}
