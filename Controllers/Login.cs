using Models;
using System.Linq;

namespace Controllers
{
    public class Login
    {
        public Login()
        {

        }

        public string login(string nombreUsuario, string password)
        {
            try
            {
                using (PortafolioEntities db = new PortafolioEntities())
                {
                    var query = from p in db.Usuario
                                where p.NombreUsuario == nombreUsuario
                                select p;

                    if (query.Count() == 0) return "Usuario no válido";

                    int existe = query.Where(u => u.NombreUsuario == nombreUsuario && u.Password == password).Count();
                    if (existe > 0) return "";

                    return "Contraseña Incorrecta";
                }
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }

        public string rolUsuario(string nombreUsuario)
        {
            try
            {
                using (PortafolioEntities db = new PortafolioEntities())
                {
                    Usuario u = db.Usuario.Single(_u => _u.NombreUsuario == nombreUsuario);

                    //var query= from p in db.Usuario
                    //                      where p.NombreUsuario == nombreUsuario
                    //                      select p;
                    // string rolUsuario=query.Where(u=>u.NombreUsuario==nombreUsuario)
                    // return rolUsuario;
                    return u.Rol.ToString();
                }
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }
    }
}