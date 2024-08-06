using Autorizacion.Abstracciones.DA;
using Autorizacion.Abstracciones.Modelos;
using System.Data.SqlClient;
using Dapper;
using Autorizacion.Helpers;

namespace Autorizacion.DA
{
    public class SeguridadDA : ISeguridadDA
    {
        IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public SeguridadDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorioDapper();
        }

        public async Task<IEnumerable<Role>> GetRolesXUsers(User user)
        {
            string sql = @"[GetRolesXUsers]";
            var consulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Role>(sql, new { Email = user.Email, UserName = user.UserName });
            return Convertidor.ConvertirLista<Abstracciones.Entidades.Role, Abstracciones.Modelos.Role>(consulta);
        }

        public async Task<User> GetUser(User user)
        {
            string sql = @"[GetUser]";
            var consulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.User>(sql, new { Email = user.Email, UserName = user.UserName });
            return Convertidor.Convertir<Abstracciones.Entidades.User, Abstracciones.Modelos.User>(consulta.FirstOrDefault());
        }

        
    }
}
