using Dapper;
using Manejo_de_Presupuestos.Models;
using Microsoft.Data.SqlClient;

namespace Manejo_de_Presupuestos.Services
{
    public interface IRepositoryTiposCuentas
    {
        void Crear(TipoCuenta tipoCuenta);
    }

    public class RepositoryTiposCuentas : IRepositoryTiposCuentas
    {
        //Insertar Tipos Cuentas en la base de datos
        private string connectionString;

        public void InsertarTiposCuentas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString( "DefaultConnection" );
        }

        //Crear tipo de cuenta
        public void Crear(TipoCuenta tipoCuenta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = connection.QuerySingle<int>($@"INSERT INTO TiposCuentas(Nombre, UsuarioId, Orden)
                                                    Values (@Nombre, @UsuarioId, 0);
                                                    SELECT SCOPE_IDENTITY();", tipoCuenta);
            tipoCuenta.Id = id;
        }
    }
}
