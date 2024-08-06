using Autorizacion.Abstracciones.Modelos;


namespace Autorizacion.Abstracciones.BW
{
    public interface IAutorizacionBW
    {
        Task<User> GetUser(User user);
        Task<IEnumerable<Role>> GetRolesXUsers(User user);
    }
}
