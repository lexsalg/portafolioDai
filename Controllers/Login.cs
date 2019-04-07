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
                using (portafolioEntities db = new portafolioEntities())
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
    }
}