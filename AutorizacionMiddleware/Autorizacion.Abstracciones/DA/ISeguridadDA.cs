using Autorizacion.Abstracciones.Modelos;


namespace Autorizacion.Abstracciones.DA
{
    public interface ISeguridadDA
    {
        Task<User> GetUser(User user);

        Task<IEnumerable<Role>> GetRolesXUsers(User user);
    }
}
