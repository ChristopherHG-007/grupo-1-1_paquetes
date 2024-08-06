using Autorizacion.Abstracciones.BW;
using Autorizacion.Abstracciones.DA;
using Autorizacion.Abstracciones.Modelos;

namespace Autorizacion.BW
{
    public class AutorizacionBW : IAutorizacionBW
    {
        private ISeguridadDA _seguridadDA;

        public AutorizacionBW(ISeguridadDA seguridadDA)
        {
            _seguridadDA = seguridadDA;
        }

        public async Task<IEnumerable<Role>> GetRolesXUsers(User user)
        {
            return await _seguridadDA.GetRolesXUsers(user);
        }

        public async Task<User> GetUser(User user)
        {
            return await _seguridadDA.GetUser(user);
        }
    }
}
