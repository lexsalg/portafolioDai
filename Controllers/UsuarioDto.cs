using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Controllers
{
    public class UsuarioDto
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public int Rol { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }

        public BindingList<UsuarioDto> ListarUsuarios()
        {
            try
            {
                using (PortafolioEntities db = new PortafolioEntities())
                {
                    var list = (from u in db.Usuario
                                select new UsuarioDto
                                {
                                    IdUsuario = u.IdUsuario,
                                    NombreUsuario = u.NombreUsuario,
                                    //Password = u.Password,
                                    Rol = u.Rol,
                                    Nombre = u.Nombre,
                                    Apellidos = u.Apellidos,
                                    Email = u.Email
                                }).ToList();
                    return new BindingList<UsuarioDto>(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new BindingList<UsuarioDto>();
            }
        }

        public void ActualizarUsuario(List<UsuarioDto> insert, List<UsuarioDto> update, List<UsuarioDto> delete)
        {
            try
            {
                using (PortafolioEntities db = new PortafolioEntities())
                {
                    foreach (UsuarioDto _u in insert)
                    {
                        Usuario e = new Usuario()
                        {
                            //IdUsuario = _u.IdUsuario,
                            NombreUsuario = _u.NombreUsuario,
                            Password = _u.Password,
                            Rol = _u.Rol,
                            Nombre = _u.Nombre,
                            Apellidos = _u.Apellidos,
                            Email = _u.Email
                        };
                        db.Usuario.Add(e);
                    }
                    foreach (UsuarioDto _u in update)
                    {
                        Usuario e = (from n in db.Usuario
                                     where n.IdUsuario == _u.IdUsuario
                                     select n).FirstOrDefault();

                        e.NombreUsuario = _u.NombreUsuario;
                        e.Password = _u.Password;
                        e.Rol = _u.Rol;
                        e.Nombre = _u.Nombre;
                        e.Apellidos = _u.Apellidos;
                        e.Email = _u.Email;

                        db.Entry(e).CurrentValues.SetValues(e);

                    }
                    foreach (UsuarioDto _u in delete)
                    {
                        Usuario e = (from n in db.Usuario
                                     where n.IdUsuario == _u.IdUsuario
                                     select n).FirstOrDefault();

                        db.Usuario.Remove(e);

                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
