using Dapper;
using Manejo_de_Presupuestos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Manejo_de_Presupuestos.Controllers
{
    public class TiposCuentasController : Controller
    {
        private readonly  string connectionString;
        public TiposCuentasController(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString( "DefaultConnection" );
        }

        public IActionResult Crear()
        {
            using ( var connection = new SqlConnection( connectionString ) )
            {
                var query = connection.Query( "SELECT 1" ).FirstOrDefault();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            if ( !ModelState.IsValid )
            {
                return View( tipoCuenta );
            }
            return View();
        }
    }
}
